﻿using HotfixMods.Core.Enums;
using HotfixMods.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotfixMods.Core.Models
{
    public class SoundKit : IHotfixesSchema, IDb2
    {
        public int Id { get; set; }
        public SoundKitSoundTypes SoundType { get; set; }
        public double VolumeFloat { get; set; }
        public int Flags { get; set; } // Exists as flag in WowTools
        public double MinDistance { get; set; }
        public double DistanceCutoff { get; set; }
        public double VolumeVariationPlus { get; set; }
        public double VolumeVariationMinus { get; set; }
        public double PitchVariationPlus { get; set; }
        public double PitchVariationMinus { get; set; }
        public double PitchAdjust { get; set; }
        public int VerifiedBuild { get; set; }
    }
}
