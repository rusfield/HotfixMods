﻿using HotfixMods.Core.Attributes;

namespace HotfixMods.Core.Models.Db2
{
    [HotfixesSchema]
    public class ItemDisplayInfoMaterialRes
    {
        public int Id { get; set; } = 0;
        public sbyte ComponentSection { get; set; } = 0;
        public int MaterialResourcesId { get; set; } = 0;
        public int ItemDisplayInfoId { get; set; } = 0;
        public int VerifiedBuild { get; set; } = -1;
    }

}