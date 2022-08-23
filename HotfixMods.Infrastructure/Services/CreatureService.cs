﻿using HotfixMods.Core.Enums;
using HotfixMods.Core.Flags;
using HotfixMods.Core.Models;
using HotfixMods.Core.Providers;
using HotfixMods.Infrastructure.Dashboard;
using HotfixMods.Infrastructure.DtoModels;
using HotfixMods.Infrastructure.DtoModels.Creatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotfixMods.Infrastructure.Services
{
    public partial class CreatureService : Service
    {
        public CreatureService(IDb2Provider db2Provider, IMySqlProvider mySqlProvider) : base(db2Provider, mySqlProvider) { }

        public async Task SaveItemAsync(CreatureDto creature)
        {
            var hotfixId = await GetNextHotfixIdAsync();
            creature.InitHotfixes(hotfixId, VerifiedBuild);

            if (creature.IsUpdate)
            {
                await _mySql.UpdateAsync(BuildCreatureTemplate(creature));
                await _mySql.UpdateAsync(BuildCreatureTemplateAddon(creature));
                await _mySql.UpdateAsync(BuildCreatureTemplateModel(creature));
                await _mySql.UpdateAsync(BuildCreatureDisplayInfo(creature));
                await _mySql.UpdateAsync(BuildCreatureDisplayInfoExtra(creature));
                await _mySql.UpdateAsync(BuildCreatureEquipTemplate(creature));
                await _mySql.UpdateAsync(BuildCreatureModelInfo(creature));
                await _mySql.UpdateManyAsync(BuildCreatureDisplayInfoOption(creature));
                await _mySql.UpdateManyAsync(BuildNpcModelItemSlotDisplayInfo(creature));
                await _mySql.UpdateAsync(BuildHotfixModsData(creature));
            }
            else
            {
                await _mySql.AddAsync(BuildCreatureTemplate(creature));
                await _mySql.AddAsync(BuildCreatureTemplateAddon(creature));
                await _mySql.AddAsync(BuildCreatureTemplateModel(creature));
                await _mySql.AddAsync(BuildCreatureDisplayInfo(creature));
                await _mySql.AddAsync(BuildCreatureDisplayInfoExtra(creature));
                await _mySql.AddAsync(BuildCreatureEquipTemplate(creature));
                await _mySql.AddAsync(BuildCreatureModelInfo(creature));
                await _mySql.AddManyAsync(BuildCreatureDisplayInfoOption(creature));
                await _mySql.AddManyAsync(BuildNpcModelItemSlotDisplayInfo(creature));
                await _mySql.AddAsync(BuildHotfixModsData(creature));
            }

            await AddHotfixes(creature.GetHotfixes());

        }

        public async Task DeleteCreatureAsync(int id)
        {
            await DeleteFromHotfixes(id);
            await DeleteFromWorld(id);
        }

        public async Task<List<CreatureDto>> GetCreaturesByCreatureId(int creatureId, Action<string, string, int>? progressCallback = null)
        {
            if (progressCallback == null)
                progressCallback = ConsoleProgressCallback;

            progressCallback("Creature", $"Retrieving DisplayInfos for Creature ID {creatureId}", 0);
            // This will only return the first model.
            // If the desired result has multiple displays, use the desired one directly instead.
            var creatureTemplateModels = await _mySql.GetManyAsync<CreatureTemplateModel>(c => c.CreatureId == creatureId);
            if (creatureTemplateModels.Any())
            {
                var creatures = await GetCreatureByDisplayIdAsync(creatureTemplateModels.Select(c => c.CreatureId).ToList(), progressCallback);
                if (creatures.Any())
                {
                    foreach (var creature in creatures)
                    {
                        if (creature.Id < IdRangeTo && creature.Id >= IdRangeFrom)
                        {
                            // Override the automatically generated Id, as this is most likely an update.
                            creature.Id = creatureId;
                            creature.IsUpdate = true;
                        }
                    }
                    progressCallback("Done", "Returning creature", 100);
                    return creatures;
                }
            }
            progressCallback("Creature", "No creatures found", 100);
            return new List<CreatureDto>();
        }

        public async Task<List<CreatureDto>> GetCreaturesByDisplayId(int creatureDisplayId, Action<string, string, int>? progressCallback = null)
        {
            if (progressCallback == null)
                progressCallback = ConsoleProgressCallback;

            progressCallback("Creature", $"Retrieving DisplayInfo for ID {creatureDisplayId}", 0);
            var result = await GetCreatureByDisplayIdAsync(new List<int>() { creatureDisplayId }, progressCallback);

            progressCallback("Done", "Returning creature", 100);
            return result;
        }

        async Task<List<CreatureDto>> GetCreatureByDisplayIdAsync(List<int> creatureDisplayIds, Action<string, string, int>? progressCallback)
        {
            int index = 0;
            var result = new List<CreatureDto>();
            foreach (var creatureDisplayId in creatureDisplayIds)
            {
                index++;
                double iterationDivider = index / creatureDisplayIds.Count();

                progressCallback("Creature", $"Retrieving Creature Template Model", (int)(10 / iterationDivider));
                CreatureTemplate? creatureTemplate = null;
                var creatureTemplateModel = await _mySql.GetAsync<CreatureTemplateModel>(c => c.CreatureDisplayId == creatureDisplayId);
                if (creatureTemplateModel != null)
                {
                    progressCallback("Creature", $"Retrieving Creature Template", (int)(15 / iterationDivider));
                    creatureTemplate = await _mySql.GetAsync<CreatureTemplate>(c => c.Entry == creatureTemplateModel.CreatureId);
                    if (creatureTemplate != null)
                        progressCallback("Creature", $"Found Creature Template ({creatureTemplate.Entry})", (int)(15 / iterationDivider));
                }

                progressCallback("Creature", $"Retrieving Display Info", (int)(20 / iterationDivider));
                var displayInfo = await _mySql.GetAsync<CreatureDisplayInfo>(c => c.Id == creatureDisplayId) ?? await _db2.GetAsync<CreatureDisplayInfo>(c => c.Id == creatureDisplayId);
                if (displayInfo == null)
                {
                    progressCallback("Failed", $"Display Info for Display Id {creatureDisplayId} not found", (int)(20 / iterationDivider));
                    continue;
                }

                var auras = new List<int>();
                if (creatureTemplate != null)
                {
                    progressCallback("Creature", $"Retrieving Auras", (int)(25 / iterationDivider));
                    var creatureTemplateAddon = await _mySql.GetAsync<CreatureTemplateAddon>(c => c.Entry == creatureTemplate.Entry);
                    if (creatureTemplateAddon != null && !string.IsNullOrWhiteSpace(creatureTemplateAddon.Auras))
                    {
                        var auraStrings = creatureTemplateAddon.Auras.Split(' ');
                        foreach (var auraString in auraStrings)
                        {
                            if (int.TryParse(auraString.Trim(), out var aura) && aura != 0)
                                auras.Add(aura);
                        }
                    }

                }
                var creature = new CreatureDto()
                {
                    Id = await GetNextIdAsync(),
                    Gender = displayInfo.Gender,
                    Race = Races.NONE,
                    CreatureType = creatureTemplate != null ? creatureTemplate.Type : CreatureTypes.HUMANOID,
                    Faction = creatureTemplate != null ? creatureTemplate.Faction : 17,
                    CreatureUnitClass = creatureTemplate != null ? creatureTemplate.UnitClass : CreatureUnitClasses.WARRIOR,
                    Level = creatureTemplate != null && creatureTemplate.MaxLevel > 0 ? creatureTemplate.MaxLevel : 30,
                    Name = creatureTemplate?.Name,
                    SubName = creatureTemplate?.SubName,
                    Scale = creatureTemplate?.Scale ?? 1.0,
                    Rank = creatureTemplate?.Rank ?? CreatureRanks.NORMAL,
                    HealthModifier = creatureTemplate?.HealthModifier ?? 1,
                    DamageModifier = creatureTemplate?.DamageModifier ?? 1,
                    FlagsExtra = (UnitFlagsExtra)(creatureTemplate?.FlagsExtra ?? 0),
                    UnitFlags = (UnitFlags)(creatureTemplate?.UnitFlags ?? 0),
                    UnitFlags2 = (UnitFlags2)(creatureTemplate?.UnitFlags2 ?? 0),
                    UnitFlags3 = (UnitFlags3)(creatureTemplate?.UnitFlags3 ?? 0),
                    ArmorModifier = creatureTemplate?.ArmorModifier ?? 1,
                    SoundId = displayInfo.SoundId,
                    RegenHealth = creatureTemplate?.RegenHealth ?? true,
                    Auras = auras,

                    IsUpdate = false,
                    AppearanceName = creatureDisplayId.ToString()
                };

                progressCallback("Creature", $"Retrieving Display Info Extra", (int)(30 / iterationDivider));
                var displayInfoExtra = await _mySql.GetAsync<CreatureDisplayInfoExtra>(c => c.Id == displayInfo.ExtendedDisplayInfoId) ?? await _db2.GetAsync<CreatureDisplayInfoExtra>(c => c.Id == displayInfo.ExtendedDisplayInfoId);
                if (displayInfoExtra == null)
                {
                    progressCallback("Creature", $"Display Info Extra not found", (int)(30 / iterationDivider));
                    result.Add(creature);
                    continue;
                }

                creature.Race = displayInfoExtra.DisplayRaceId;

                progressCallback("Customizations", $"Retrieving available customizations", (int)(40 / iterationDivider));
                var availableCustomizations = await GetAvailableCustomizations(displayInfoExtra.DisplayRaceId, displayInfo.Gender);
                progressCallback("Customizations", $"Retrieving creature customizations", (int)(60 / iterationDivider));
                var customizations = await _mySql.GetManyAsync<CreatureDisplayInfoOption>(h => h.CreatureDisplayInfoExtraId == displayInfoExtra.Id) ?? await _db2.GetManyAsync<CreatureDisplayInfoOption>(h => h.CreatureDisplayInfoExtraId == displayInfoExtra.Id);
                var creatureCustomizations = new Dictionary<int, int?>();

                foreach (var availableCustomization in availableCustomizations)
                {
                    progressCallback("Customizations", $"Preparing {availableCustomization.Key.Name}", (int)(70 / iterationDivider));

                    var customization = customizations.Where(hc => hc.ChrCustomizationOptionId == availableCustomization.Key.Id).FirstOrDefault();

                    if (customization != null)
                    {
                        creatureCustomizations.Add(customization.ChrCustomizationOptionId, customization.ChrCustomizationChoiceId);
                    }
                    else
                    {
                        creatureCustomizations.Add(availableCustomization.Key.Id, availableCustomization.Value.First().Id);
                    }
                }
                creature.Customizations = creatureCustomizations;

                progressCallback("Equipment", $"Retrieving equipment", (int)(80 / iterationDivider));
                var hotfixEquipment = await _mySql.GetManyAsync<NpcModelItemSlotDisplayInfo>(npc => npc.NpcModelId == displayInfoExtra.Id);
                var db2Equipment = await _db2.GetManyAsync<NpcModelItemSlotDisplayInfo>(npc => npc.NpcModelId == displayInfoExtra.Id);

                for (int i = 0; i <= Enum.GetValues(typeof(ArmorSlots)).Cast<int>().Max(); i++)
                {
                    var itemSlot = (ArmorSlots)i;
                    progressCallback("Equipment", $"Handling {itemSlot.ToString().ToLower().Replace("_", "")} slot", (int)(90 / iterationDivider));

                    var hotfixItem = hotfixEquipment.FirstOrDefault(h => (int)h.ItemSlot == i);
                    var db2Item = db2Equipment.FirstOrDefault(d => (int)d.ItemSlot == i);
                    var item = hotfixItem != null ? hotfixItem : (db2Item != null ? db2Item : null);
                    if (item == null || item.ItemDisplayInfoId == 0)
                        continue;

                    switch (itemSlot)
                    {
                        case ArmorSlots.HEAD:
                            creature.HeadItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.SHOULDERS:
                            creature.ShouldersItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.CHEST:
                            creature.ChestItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.WAIST:
                            creature.WaistItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.HANDS:
                            creature.HandsItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.TABARD:
                            creature.TabardItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.SHIRT:
                            creature.ShirtItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.BACK:
                            creature.BackItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.WRISTS:
                            creature.WristsItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.LEGS:
                            creature.LegsItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.FEET:
                            creature.FeetItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                        case ArmorSlots.QUIVER:
                            creature.QuiverItemDisplayInfoId = item.ItemDisplayInfoId;
                            break;
                    }
                }

                progressCallback("Equipment", $"Handling weapons", (int)(95 / iterationDivider));
                if (creatureTemplate != null)
                {
                    var creatureEquipTemplate = await _mySql.GetAsync<CreatureEquipTemplate>(c => c.CreatureId == creatureTemplate.Entry);
                    if (creatureEquipTemplate != null)
                    {
                        if (creatureEquipTemplate.ItemId1 > 0)
                            creature.MainHandItemId = creatureEquipTemplate.ItemId1;
                        if (creatureEquipTemplate.AppearanceModId1 > 0)
                            creature.MainHandItemAppearanceModifierId = creatureEquipTemplate.AppearanceModId1;
                        if (creatureEquipTemplate.ItemVisual1 > 0)
                            creature.MainHandItemVisual = creatureEquipTemplate.ItemVisual1;

                        if (creatureEquipTemplate.ItemId2 > 0)
                            creature.OffHandItemId = creatureEquipTemplate.ItemId2;
                        if (creatureEquipTemplate.AppearanceModId2 > 0)
                            creature.OffHandItemAppearanceModifierId = creatureEquipTemplate.AppearanceModId2;
                        if (creatureEquipTemplate.ItemVisual2 > 0)
                            creature.OffHandItemVisual = creatureEquipTemplate.ItemVisual2;

                        if (creatureEquipTemplate.ItemId3 > 0)
                            creature.RangedItemId = creatureEquipTemplate.ItemId3;
                        if (creatureEquipTemplate.AppearanceModId3 > 0)
                            creature.RangedItemAppearanceModifierId = creatureEquipTemplate.AppearanceModId3;
                        if (creatureEquipTemplate.ItemVisual3 > 0)
                            creature.RangedItemVisual = creatureEquipTemplate.ItemVisual3;
                    }
                }
                result.Add(creature);
            }

            return result;
        }

        public async Task<List<DashboardModel>> GetCreatureDashboardAsync()
        {
            var creatures = await _mySql.GetManyAsync<CreatureTemplate>(c => c.VerifiedBuild == VerifiedBuild);
            var result = new List<DashboardModel>();
            foreach (var creature in creatures)
            {
                var displayInfo = await _mySql.GetAsync<CreatureDisplayInfoExtra>(c => c.Id == creature.Entry);
                if (displayInfo == null)
                    continue;
                result.Add(new DashboardModel()
                {
                    Id = creature.Entry,
                    Name = creature.Name,
                    Comment = "TODO",
                    AvatarUrl = $"/images/creatures/avatars/{displayInfo.DisplaySexId.ToString().ToLower()}/{displayInfo.DisplayRaceId.ToString().ToLower().Replace("_", "")}.jpg"
                });
            }
            // Newest on top
            result.Reverse();
            return result;
        }

        async Task DeleteFromHotfixes(int id)
        {
            var creatureDisplayInfo = await _mySql.GetAsync<CreatureDisplayInfo>(c => c.Id == id);
            var creatureDisplayInfoExtra = await _mySql.GetAsync<CreatureDisplayInfoExtra>(c => c.Id == id);
            var creatureDisplayInfoOptions = await _mySql.GetManyAsync<CreatureDisplayInfoOption>(c => c.CreatureDisplayInfoExtraId == id);
            var npcModelItemSlotDisplayInfos = await _mySql.GetManyAsync<NpcModelItemSlotDisplayInfo>(c => c.NpcModelId == id);
            var hotfixModsData = await _mySql.GetAsync<HotfixModsData>(h => h.Id == id);

            if (null != creatureDisplayInfo)
                await _mySql.DeleteAsync(creatureDisplayInfo);

            if (null != creatureDisplayInfoExtra)
                await _mySql.DeleteAsync(creatureDisplayInfoExtra);

            if (creatureDisplayInfoOptions.Any())
                await _mySql.DeleteManyAsync(creatureDisplayInfoOptions);

            if (npcModelItemSlotDisplayInfos.Any())
                await _mySql.DeleteManyAsync(npcModelItemSlotDisplayInfos);

            var hotfixData = await _mySql.GetManyAsync<HotfixData>(h => h.UniqueId == id);
            if (hotfixData != null && hotfixData.Count() > 0)
            {
                foreach (var hotfix in hotfixData)
                {
                    hotfix.Status = HotfixStatuses.INVALID;
                }
                await _mySql.UpdateManyAsync(hotfixData);
            }

            if (null != hotfixModsData)
                await _mySql.DeleteAsync(hotfixModsData);
        }

        async Task DeleteFromWorld(int id)
        {
            var creatureTemplate = await _mySql.GetAsync<CreatureTemplate>(c => c.Entry == id);
            var creatureTemplateAddon = await _mySql.GetAsync<CreatureTemplateAddon>(c => c.Entry == id);
            var creatureTemplateModel = await _mySql.GetAsync<CreatureTemplateModel>(c => c.CreatureId == id);
            var creatureEquipTemplate = await _mySql.GetAsync<CreatureEquipTemplate>(c => c.CreatureId == id);
            var creatureModelInfo = await _mySql.GetAsync<CreatureModelInfo>(c => c.DisplayId == id);

            if(null != creatureTemplate)
                await _mySql.DeleteAsync(creatureTemplate);

            if(null != creatureTemplateAddon)
                await _mySql.DeleteAsync(creatureTemplateAddon);

            if(null != creatureTemplateModel)
                await _mySql.DeleteAsync(creatureTemplateModel);

            if(null != creatureEquipTemplate)
                await _mySql.DeleteAsync(creatureEquipTemplate);

            if(null != creatureModelInfo)
                await _mySql.DeleteAsync(creatureModelInfo);
        }
    }
}