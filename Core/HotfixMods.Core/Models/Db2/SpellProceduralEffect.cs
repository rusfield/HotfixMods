﻿using HotfixMods.Core.Attributes;

namespace HotfixMods.Core.Models.Db2
{
    [HotfixesSchema]
    public class SpellProceduralEffect
    {
        public int Id { get; set; } = 1;
        public sbyte Type { get; set; } = 0;
        public decimal Value1 { get; set; } = 0;
        public decimal Value2 { get; set; } = 0;
        public decimal Value3 { get; set; } = 0;
        public decimal Value4 { get; set; } = 0;
        public int VerifiedBuild { get; set; } = -1;
    }
}