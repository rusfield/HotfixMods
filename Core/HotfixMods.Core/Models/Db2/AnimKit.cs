﻿using HotfixMods.Core.Attributes;

namespace HotfixMods.Core.Models.Db2
{
    [HotfixesSchema]
    public class AnimKit
    {
        public int Id { get; set; } = 0;
        public uint OneShotDuration { get; set; } = 0;
        public uint OneShotStopAnimKitId { get; set; } = 0;
        public uint LowDefAnimKitId { get; set; } = 0;
        public int VerifiedBuild { get; set; } = -1;
    }
}
