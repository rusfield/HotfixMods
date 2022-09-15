﻿using HotfixMods.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotfixMods.Core.Models
{
    public class SpellVisualAnim : IDb2, IHotfixesSchema
    {
        public int Id { get; set; }
        public int InitialAnimId { get; set; }
        public int LoopAnimId { get; set; }
        public int AnimKitId { get; set; }
    }
}