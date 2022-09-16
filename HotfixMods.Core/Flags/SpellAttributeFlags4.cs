﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotfixMods.Core.Flags
{
    [Flags]
    public enum SpellAttributeFlags4 : long
    {
        NONE = 0,
        NO_CAST_LOG = 1,
        CLASS_TRIGGER_ONLY_ON_TARGET = 2,
        AURA_EXPIRES_OFFLINE = 4,
        NO_HELPFUL_THREAT = 8,
        NO_HARMFUL_THREAT = 16,
        ALLOW_CLIENT_TARGETING = 32,
        CANNOT_BE_STOLEN = 64,
        ALLOW_CAST_WHILE_CASTING = 128,
        IGNORE_DAMAGE_TAKEN_MODIFIERS = 256,
        COMBAT_FEEDBACK_WHEN_USABLE = 512,
        WEAPON_SPEED_COST_SCALING = 1024,
        NO_PARTIAL_IMMUNITY = 2048,
        AURA_IS_BUFF = 4096,
        DO_NOT_LOG_CASTER = 8192,
        REACTIVE_DAMAGE_PROC = 16384,
        NOT_IN_SPELLBOOK = 32768,
        NOT_IN_ARENA_OR_RATED_BATTLEGROUND = 65536,
        IGNORE_DEFAULT_ARENA_RESTRICTIONS = 131072,
        BOUNCY_CHAIN_MISSILES = 262144,
        ALLOW_PROC_WHILE_SITTING = 524288,
        AURA_NEVER_BOUNCES = 1048576,
        ALLOW_ENTERING_ARENA = 2097152,
        PROC_SUPPRESS_SWING_ANIM = 4194304,
        SUPPRESS_WEAPON_PROCS = 8388608,
        AUTO_RANGED_COMBAT = 16777216,
        OWNER_POWER_SCALING = 33554432,
        ONLY_FLYING_AREAS = 67108864,
        FORCE_DISPLAY_CASTBAR = 134217728,
        IGNORE_COMBAT_TIMER = 268435456,
        AURA_BOUNCE_FAILS_SPELL = 536870912,
        OBSOLETE = 1073741824,
        USE_FACING_FROM_SPELL = 2147483648
    }
}
