﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotfixMods.Core.Flags
{
    [Flags]
    public enum SpellAttributeFlags13 : long
    {
        NONE = 0,
        ALLOW_CLASS_ABILITY_PROCS = 1,
        ALLOW_WHILE_FEARED_BY_FEAR_MECHANIC = 2,
        COOLDOWN_SHARED_WITH_AI_GROUP = 4,
        INTERRUPTS_CURRENT_CAST = 8,
        PERIODIC_SCRIPT_RUNS_LATE = 16,
        RECIPE_HIDDEN_UNTIL_KNOWN = 32,
        CAN_PROC_FROM_LIFESTEAL = 64,
        NAMEPLATE_PERSONAL_BUFFSDEBUFFS = 128,
        CANNOT_LIFESTEALLEECH = 256,
        GLOBAL_AURA = 512,
        NAMEPLATE_ENEMY_DEBUFFS = 1024,
        ALWAYS_ALLOW_PVP_FLAGGED_TARGET = 2048,
        DO_NOT_CONSUME_AURA_STACK_ON_PROC = 4096,
        DO_NOT_PVP_FLAG_CASTER = 8192,
        ALWAYS_REQUIRE_PVP_TARGET_MATCH = 16384,
        DO_NOT_FAIL_IF_NO_TARGET = 32768,
        DISPLAYED_OUTSIDE_OF_SPELLBOOK = 65536,
        CHECK_PHASE_ON_STRING_ID_RESULTS = 131072,
        DO_NOT_ENFORCE_SHAPESHIFT_REQUIREMENTS = 262144,
        AURA_PERSISTS_THROUGH_TAME_PET = 524288,
        PERIODIC_REFRESH_EXTENDS_DURATION = 1048576,
        USE_SKILL_RANK_AS_SPELL_LEVEL = 2097152,
        AURA_ALWAYS_SHOWN = 4194304,
        USE_SPELL_LEVEL_FOR_ITEM_SQUISH_COMPENSATION = 8388608,
        CHAIN_BY_MOST_HIT = 16777216,
        DO_NOT_DISPLAY_CAST_TIME = 33554432,
        ALWAYS_ALLOW_NEGATIVE_HEALING_PERCENT_MODIFIERS = 67108864,
        DO_NOT_ALLOW_DISABLE_MOVEMENT_INTERRUPT = 134217728,
        ALLOW_AURA_ON_LEVEL_SCALE = 268435456,
        REMOVE_AURA_ON_LEVEL_SCALE = 536870912,
        RECOMPUTE_AURA_ON_LEVEL_SCALE = 1073741824,
        UPDATE_FALL_SPEED_AFTER_AURA_REMOVAL = 2147483648
    }
}
