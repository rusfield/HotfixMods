﻿using HotfixMods.Core.Models;
using HotfixMods.Infrastructure.DtoModels;
using HotfixMods.Core.Enums;
using HotfixMods.Infrastructure.DefaultModels;

namespace HotfixMods.Infrastructure.Services
{
    public partial class SpellVisualKitService
    {
        SpellVisualKit BuildSpellVisualKit(SpellVisualKitDto dto)
        {
            dto.AddHotfix(dto.Id, TableHashes.SPELL_VISUAL_KIT, HotfixStatuses.VALID);
            return new()
            {
                Id = dto.Id,
                VerifiedBuild = VerifiedBuild
            };
        }

        SpellVisualKitEffect BuildSpellVisualKitEffect(SpellVisualKitDto dto)
        {
            dto.AddHotfix(dto.Id, TableHashes.SPELL_VISUAL_KIT_EFFECT, HotfixStatuses.VALID);
            return new()
            {
                ParentSpellVisualKitId = dto.Id,
                Id = dto.Id,
                VerifiedBuild = VerifiedBuild,

                Effect = dto.Effect ?? Default.SpellVisualKitEffect.Effect,
                EffectType = dto.EffectType ?? Default.SpellVisualKitEffect.EffectType
            };
        }

        SpellVisualKitModelAttach BuildSpellVisualKitModelAttach(SpellVisualKitDto dto)
        {
            dto.AddHotfix(dto.Id, TableHashes.SPELL_VISUAL_KIT_MODEL_ATTACH, HotfixStatuses.VALID);
            return new()
            {
                ParentSpellVisualKitId = dto.Id,
                SpellVisualEffectNameId = dto.Id,
                Id = dto.Id,
                VerifiedBuild = VerifiedBuild
            };
        }

        SpellVisualEffectName BuildSpellVisualEffectName(SpellVisualKitDto dto)
        {
            dto.AddHotfix(dto.Id, TableHashes.SPELL_VISUAL_EFFECT_NAME, HotfixStatuses.VALID);
            return new()
            {
                Id = dto.Id,
                VerifiedBuild = VerifiedBuild,

                Alpha = dto.Alpha ?? Default.SpellVisualEffectName.Alpha,
                GenericId = dto.GenericId ?? Default.SpellVisualEffectName.GenericId,
                MaxAllowedScale = dto.MaxAllowedScale ?? Default.SpellVisualEffectName.MaxAllowedScale,
                MinAllowedScale = dto.MinAllowedScale ?? Default.SpellVisualEffectName.MinAllowedScale,
                ModelFileDataId = dto.ModelFileDataId ?? Default.SpellVisualEffectName.ModelFileDataId,
                ModelPosition = dto.ModelPosition ?? Default.SpellVisualEffectName.ModelPosition,
                Scale = dto.Scale ?? Default.SpellVisualEffectName.Scale,
                TextureFileDataId = dto.TextureFileDataId ?? Default.SpellVisualEffectName.TextureFileDataId,
                Type = dto.Type ?? Default.SpellVisualEffectName.Type
            };
        }
    }
}
