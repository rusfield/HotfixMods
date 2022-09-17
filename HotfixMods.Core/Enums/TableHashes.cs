﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Imported from WowPacketParser
// https://github.com/TrinityCore/WowPacketParser

namespace HotfixMods.Core.Enums
{
    public enum TableHashes : long
    {
        GAME_OBJECT_ART_KIT = 2407661,
        CAMPAIGN_X_QUEST_LINE = 13326836,
        ITEM_X_ITEM_EFFECT = 13330255,
        SPELL_ICON = 14913004,
        QUEST_OBJECTIVE = 20077728,
        UI_MODEL_SCENE = 21457424,
        LORE_TEXT_PUBLIC = 22459322,
        ARTIFACT = 23454815,
        BEAM_EFFECT = 25144992,
        GUILD_PERK_SPELLS = 26567700,
        BROADCAST_TEXT = 35137211,
        MANIFEST_INTERFACE_ITEM_ICON = 36381654,
        GARR_UI_ANIM_CLASS_INFO = 39598960,
        ITEM_ARMOR_TOTAL = 43864318,
        SPELL_VISUAL_EFFECT_NAME = 48336690,
        MOVIE = 53344787,
        UI_COVENANT_PREVIEW = 77566787,
        ITEM_RANDOM_PROPERTIES = 79508367,
        UI_MAP_ART = 84449948,
        UI_SCRIPTED_ANIMATION_EFFECT = 88765550,
        SKILL_RACE_CLASS_INFO = 112059424,
        FACTION = 116794583,
        HOTFIXES = 119574838,
        SOUND_BUS = 120365402,
        QUEST_X_UI_WIDGET_SET = 131736029,
        GUILD_EMBLEM = 135630320,
        LIQUID_TYPE_X_TEXTURE = 139063209,
        UNIT_TEST_SPARSE = 145293629,
        ITEM_SPEC = 148532778,
        PATH_PROPERTY = 149245792,
        CFG_CONFIGS = 153052569,
        AREA_GROUP_MEMBER = 157446066,
        TRANSFORM_MATRIX = 173929978,
        TRANSMOG_ILLUSION = 177674191,
        VEHICLE = 178219711,
        LIGHT_DATA = 181829311,
        JOURNAL_SECTION_X_DIFFICULTY = 184881520,
        UNIT_BLOOD_LEVELS = 186245800,
        GAME_PARAMETER = 188958204,
        GRADIENT_EFFECT = 191387957,
        GM_SURVEY_SURVEYS = 202076719,
        GLYPH_BINDABLE_SPELL = 222011635,
        CHALLENGE_MODE_ITEM_BONUS_OVERRIDE = 232552374,
        GARR_MISSION = 234224168,
        FRIENDSHIP_REPUTATION = 234233465,
        GARR_MECHANIC_SET_X_MECHANIC = 234762603,
        UNIT_CONDITION = 240389885,
        OCCLUDER_LOCATION = 243426892,
        SOUND_FILTER = 250652247,
        UI_MAP_FOG_OF_WAR_VISUALIZATION = 253449282,
        QUEST_V2_CLI_TASK = 261693969,
        NUM_TALENTS_AT_LEVEL = 262173489,
        GARR_PLOT_UI_CATEGORY = 264699590,
        FACTION_TEMPLATE = 270052821,
        LOADING_SCREEN_SKIN = 278760405,
        ITEM_BAG_FAMILY = 288365895,
        MODEL_ANIM_CLOAK_DAMPENING = 291179024,
        CREATURE_DISPLAY_INFO_COND = 293862385,
        CHAR_HAIR_GEOSETS = 299101852,
        PVP_SCOREBOARD_COLUMN_HEADER = 301254298,
        MCR_SLOT_XMCR_CATEGORY = 312181299,
        MANIFEST_INTERFACE_ACTION_ICON = 312611201,
        SPELL_SCRIPT_TEXT = 312611497,
        ITEM_BONUS_LIST_WARFORGE_LEVEL_DELTA = 312962813,
        MOVIE_VARIATION = 315695528,
        STABLE_SLOT_PRICES = 318283405,
        FRIENDSHIP_REP_REACTION = 322001913,
        GUILD_COLOR_BORDER = 331233397,
        GAME_OBJECTS = 331613093,
        UI_WIDGET_STRING_SOURCE = 336222293,
        ANIM_KIT_CONFIG = 337491991,
        CREATURE_SPELL_DATA = 338879469,
        ITEM_SPEC_OVERRIDE = 345681529,
        TRANSMOG_SET = 356071576,
        PET_LOYALTY = 356679055,
        SCREEN_EFFECT_TYPE = 365870753,
        BONE_WIND_MODIFIER_MODEL = 366014372,
        BATTLE_PET_SPECIES_STATE = 366509520,
        ARTIFACT_POWER_RANK = 367248955,
        UI_TEXTURE_KIT = 367806651,
        COMBAT_CONDITION = 368401261,
        OCCLUDER = 369041100,
        WORLD_MAP_TRANSFORMS = 371324299,
        COMMENTATOR_TRACKED_COOLDOWN = 378810315,
        QUEST_XUI_QUEST_DETAILS_THEME = 379984323,
        GAME_OBJECT_DIFF_ANIM_MAP = 390211750,
        INVASION_CLIENT_DATA = 410588437,
        ITEM_SEARCH_NAME = 428746933,
        SPELL_RUNE_COST = 438801950,
        TEXTURE_FILE_DATA = 440872980,
        AREA_TRIGGER = 441483745,
        BATTLE_PET_BREED_QUALITY = 458903206,
        GUILD_COLOR_EMBLEM = 462112558,
        SPECIALIZATION_SPELLS_DISPLAY = 476847390,
        CREATURE_X_UI_WIDGET_SET = 484216018,
        ZONE_LIGHT_POINT = 486089069,
        EMOTES_TEXT_SOUND = 490390919,
        WORLD_STATE_EXPRESSION = 492039028,
        WORLD_MAP_OVERLAY = 494145138,
        SPELL_LEVELS = 501138918,
        TRANSMOG_SET_ITEM = 505524148,
        ITEM_CHILD_EQUIPMENT = 512648579,
        SPELL_CHAIN_EFFECTS = 517656225,
        GARR_SPECIALIZATION = 518419645,
        SEAMLESS_SITE = 519658371,
        CREATURE_TYPE = 528526655,
        SCENE_SCRIPT_TEXT = 537670055,
        DECLINED_WORD = 540203103,
        PARAGON_REPUTATION = 541662981,
        SPELL_REAGENTS_CURRENCY = 541701644,
        SPELL_VISUAL_KIT_AREA_MODEL = 545961245,
        EMOTES = 554245018,
        CREATURE_IMMUNITIES = 555625967,
        CHARACTER_FACIAL_HAIR_STYLES = 555942850,
        ZONE_INTRO_MUSIC_TABLE = 558463671,
        BROADCAST_TEXT_SOUND_STATE = 561912705,
        GARR_SITE_LEVEL = 583472526,
        ACHIEVEMENT_CATEGORY = 588988749,
        JOURNAL_TIER_X_INSTANCE = 593571724,
        SPELL_EFFECT_GROUP_SIZE = 599752208,
        CREATURE_X_DISPLAY_INFO = 600565378,
        LFG_DUNGEON_GROUP = 603342232,
        CHAT_PROFANITY = 603412935,
        GARR_TALENT = 604014940,
        HELMET_GEOSET_DATA = 604774165,
        POSITIONER = 604866126,
        TRANSMOG_SET_GROUP = 618355886,
        TRADE_SKILL_CATEGORY = 624597867,
        MINOR_TALENT = 631345831,
        NAMES_RESERVED = 633457427,
        PHASE_X_PHASE_GROUP = 634137177,
        SPEC_SET_MEMBER = 635393838,
        SOUND_AMBIENCE_FLAVOR = 647093267,
        JOURNAL_TIER = 651763705,
        EXPECTED_STAT = 665315199,
        SPELL_X_SPELL_VISUAL = 666345498,
        PVP_BRAWL = 671580526,
        EXPECTED_STAT_MOD = 671633915,
        JOURNAL_ITEM_X_DIFFICULTY = 678313527,
        SPELL_CLASS_OPTIONS = 680438657,
        MOUNT_TYPE_X_CAPABILITY = 685366953,
        HOLIDAY_DESCRIPTIONS = 690463935,
        SPELL_CLUTTER_AREA_EFFECT_COUNTS = 691622956,
        PET_PERSONALITY = 698949654,
        GARR_FOLL_ITEM_SET_MEMBER = 708957985,
        AZERITE_ESSENCE_POWER = 713478033,
        CONTRIBUTION = 713863784,
        MYTHIC_PLUS_SEASON = 718838394,
        SPELL_DISPEL_TYPE = 729546851,
        FOOTPRINT_TEXTURES = 733830049,
        IMPORT_PRICE_SHIELD = 735996568,
        SOUND_KIT_CHILD = 736158310,
        GARR_PLOT = 752402434,
        QUEST_INFO = 756143922,
        AZERITE_POWER_SET_MEMBER = 764195431,
        FILE_DATA_COMPLETE = 766838915,
        ITEM_PRICE_BASE = 769695381,
        VEHICLE_POI_TYPE = 774472957,
        HEIRLOOM = 779857838,
        CURRENCY_TYPES = 793851790,
        UI_PARTY_POSE = 793948404,
        ARTIFACT_POWER_PICKER = 795180358,
        SOUND_BUS_OVERRIDE = 799013087,
        MANAGED_WORLD_STATE_INPUT = 800406471,
        CHR_CUSTOMIZATION_OPTION = 800559195,
        GROUP_FINDER_CATEGORY = 803663642,
        UI_TEXTURE_ATLAS_ELEMENT = 811684074,
        CHAR_BASE_INFO = 812099832,
        SPELL_LABEL = 813076512,
        ITEM_PET_FOOD = 819861596,
        WORLD_STATE_UI = 825311328,
        UI_WIDGET_VIS_TYPE_DATA_REQ = 825613771,
        CHR_CLASS_RACE_SEX = 836435647,
        ITEM_X_BONUS_TREE = 844464874,
        TERRAIN_MATERIAL = 844575557,
        MODEL_RIBBON_QUALITY = 846032527,
        GARR_ABILITY_CATEGORY = 852966632,
        SPELL_VISUAL_ANIM = 859088734,
        EXHAUSTION = 864466243,
        SUMMON_PROPERTIES = 868868520,
        GARR_BUILDING = 878382519,
        PVP_STAT = 882987483,
        ANIM_KIT_REPLACEMENT = 887102220,
        MANIFEST_M_P3 = 893275916,
        SOUND_KIT_NAME = 894855762,
        GROUP_FINDER_ACTIVITY_GRP = 896541910,
        CHR_CLASS_VILLAIN = 898992118,
        SOUND_AMBIENCE = 905567832,
        SOUND_KIT = 908293937,
        CHAR_SECTIONS = 909133907,
        ARTIFACT_POWER_LINK = 913866359,
        UI_CAMERA_TYPE = 914907145,
        CREATURE_FAMILY = 916407967,
        SPELL_MISSILE_MOTION = 930182777,
        ANIM_KIT_BONE_SET_ALIAS = 931155434,
        GARR_MISSION_TEXTURE = 939278707,
        HELMET_GEOSET_VIS_DATA = 940448223,
        UI_MAP_ART_STYLE_LAYER = 942518842,
        MAP_CHALLENGE_MODE = 943410215,
        SCHEDULED_WORLD_STATE = 945022647,
        ARENA_CC_ITEM = 948502808,
        PVP_TALENT_UNLOCK = 955569378,
        LOCATION = 961296167,
        SANDBOX_SCALING = 961827078,
        ITEM_BONUS_LIST_LEVEL_DELTA = 962617990,
        UI_EVENT_TOAST = 978178762,
        DEVICE_BLACKLIST = 983446676,
        UI_DUNGEON_SCORE_RARITY = 983782919,
        QUEST_V2 = 986198281,
        NAMES_RESERVED_LOCALE = 986374917,
        CREATURE_DISP_X_UI_CAMERA = 995845379,
        BANNED_ADD_ONS = 998089029,
        PATH_NODE = 1000230050,
        MISSILE_TARGETING = 1006998082,
        SOURCE_INFO = 1010104591,
        BATTLE_PET_ABILITY_STATE = 1012231747,
        IMPORT_PRICE_QUALITY = 1013013523,
        PVP_TALENT_CATEGORY = 1013403972,
        CURRENCY_CONTAINER = 1013770791,
        HELMET_ANIM_SCALING = 1015057242,
        SPELL_DESCRIPTION_VARIABLES = 1019780096,
        WEAPON_TRAIL_PARAM = 1022281925,
        QUEST_XP = 1032430962,
        IMPORT_PRICE_ARMOR = 1043802212,
        ANIM_KIT_SEGMENT = 1050181896,
        MODIFIED_CRAFTING_REAGENT_SLOT = 1059920561,
        CREATURE_DISPLAY_INFO_COND_X_CHOICE = 1065049700,
        LOCALE = 1065724855,
        SPELL_CLUTTER_FRAME_RATES = 1071088011,
        ITEM_EFFECT = 1073915313,
        CAMPAIGN_X_CONDITION = 1075727765,
        VIDEO_HARDWARE = 1078558972,
        SPELL_SCALING = 1089023333,
        UI_CAM_FBACK_TRANSMOG_WEAPON = 1100209526,
        MAW_POWER_RARITY = 1103512207,
        STARTUP_FILES = 1106748214,
        SOULBIND_CONDUIT_ITEM = 1107374491,
        GARR_FOLLOWER_QUALITY = 1107630156,
        RESEARCH_BRANCH = 1108318853,
        ITEM_APPEARANCE = 1109793673,
        DEATH_THUD_LOOKUPS = 1110901647,
        TALENT_TAB = 1113426120,
        RACIAL_MOUNTS = 1113597634,
        RECIPE_PROGRESSION_GROUP_ENTRY = 1114251091,
        GUILD_SHIRT_BORDER = 1122191719,
        GM_SURVEY_ANSWERS = 1141219786,
        BATTLE_PET_SPECIES_X_ABILITY = 1143173908,
        ITEM_BONUS_LIST_GROUP = 1149865041,
        UNIT_POWER_BAR = 1161940423,
        SPELL_SCRIPT = 1163127287,
        GARR_CLASS_SPEC = 1165344527,
        SCALING_STAT_DISTRIBUTION = 1171454503,
        POSITIONER_STATE_ENTRY = 1176493125,
        SPELL_VISUAL_KIT_EFFECT = 1181150530,
        GARR_ENCOUNTER_X_MECHANIC = 1187330571,
        SPELL_NAME = 1187407512,
        UI_CANVAS = 1217349157,
        CAMERA_SHAKES = 1220051873,
        AREA_TRIGGER_BOX = 1225579890,
        CHR_MODEL = 1228184686,
        NPC_SOUNDS = 1230280159,
        GARR_TAL_TREE_X_GARR_TAL_RESEARCH = 1239705838,
        AREA_POI_STATE = 1240462528,
        CHR_MODEL_TEXTURE_LAYER = 1240660143,
        STRING_LOOKUPS = 1247625963,
        CRITERIA_TREE = 1255424668,
        SOUND_BUS_NAME = 1257636865,
        CURVE = 1272569722,
        GARR_UI_ANIM_RACE_INFO = 1280956582,
        OBJECT_EFFECT_GROUP = 1282325123,
        UI_CAM_FBACK_TRANSMOG_CHR_RACE = 1296758631,
        CHARACTER_FACE_BONE_SET = 1298280559,
        PVP_SCALING_EFFECT_TYPE = 1300867943,
        WORLD_STATE_ZONE_SOUNDS = 1303106555,
        CONTRIBUTION_STYLE_CONTAINER = 1314352746,
        DUNGEON_MAP = 1317353695,
        ITEM_BONUS_TREE = 1318924764,
        DRIVER_BLACKLIST = 1326512502,
        CAMERA_EFFECT = 1335965597,
        SPECIALIZATION_SPELLS = 1337593436,
        ITEM = 1344507586,
        UI_COVENANT_ABILITY = 1348339269,
        PVP_TALENT_SLOT_UNLOCK = 1351908423,
        TAXI_NODES = 1356405368,
        PRESTIGE_LEVEL_INFO = 1362239809,
        UI_MAP_ASSIGNMENT = 1364435768,
        SPELL_VISUAL_MISSILE = 1369604944,
        ANIM_KIT_PRIORITY = 1375553837,
        HIGHLIGHT_COLOR = 1377377290,
        VOCAL_UI_SOUNDS = 1378031962,
        UI_WIDGET_X_WIDGET_SET = 1385971161,
        FOOTSTEP_TERRAIN_LOOKUP = 1387041889,
        SPELL_VISUAL_KIT_PICKER_ENTRY = 1397419395,
        ANIM_REPLACEMENT = 1399499241,
        WORLD_MAP_AREA = 1404082561,
        CHR_RACES = 1408333884,
        VIRTUAL_ATTACHMENT = 1411256130,
        QUEST_SORT = 1417267977,
        TRANSMOG_HOLIDAY = 1417785224,
        HOLIDAY_NAMES = 1419319386,
        CHR_RACE_RACIAL_ABILITY = 1427010835,
        UI_MAP_LINK = 1433988585,
        BATTLEMASTER_LIST = 1435332686,
        CHR_CUSTOMIZATION_SKINNED_MODEL = 1436347628,
        CINEMATIC_SEQUENCES = 1441530096,
        UI_MODEL_SCENE_ACTOR_DISPLAY = 1442854927,
        CHR_CREATE_CLASS_ANIM_TARGET = 1453226923,
        CHARACTER_SERVICE_INFO = 1454018603,
        CELESTIAL_BODY = 1457737723,
        JOURNAL_ENCOUNTER = 1463296112,
        ARTIFACT_UNLOCK = 1473366888,
        SCHEDULED_WORLD_STATE_GROUP = 1473491185,
        WB_ACCESS_CONTROL_LIST = 1477136115,
        SOUND_ENVELOPE = 1485693696,
        SPELL_VISUAL_COLOR_EFFECT = 1491544390,
        CHR_CUSTOMIZATION_GEOSET = 1500945592,
        ZONE_LIGHT = 1509092176,
        BONUS_ROLL = 1512352357,
        BOUNTY = 1531407228,
        AREA_TRIGGER_ACTION_SET = 1548466975,
        UI_EXPANSION_DISPLAY_INFO = 1556018082,
        LIGHT = 1556783290,
        OCCLUDER_NODE = 1558754792,
        LOOK_AT_CONTROLLER = 1562431239,
        ITEM_TO_BATTLE_PET = 1563357608,
        RAND_PROP_POINTS = 1569517478,
        ANIM_KIT_CONFIG_BONE_SET = 1570721457,
        CHAR_BASE_SECTION = 1571082092,
        OBJECT_EFFECT_PACKAGE = 1581158180,
        ITEM_CURRENCY_VALUE = 1585919468,
        MYTHIC_PLUS_SEASON_TRACKED_AFFIX = 1598513332,
        WEATHER_X_PARTICULATE = 1615247723,
        POSITIONER_STATE = 1623486109,
        SPELL_CASTING_REQUIREMENTS = 1627543382,
        CHR_CUSTOMIZATION_REQ = 1631787621,
        AREA_CONDITIONAL_DATA = 1635292571,
        POWER_DISPLAY = 1638210446,
        ADVENTURE_MAP_POI = 1651896055,
        GARR_TALENT_RESEARCH = 1653629717,
        CREATURE_X_CONTRIBUTION = 1653761381,
        GARR_MISSION_X_ENCOUNTER = 1653915679,
        OBJECT_EFFECT_MODIFIER = 1657342891,
        GARR_TALENT_MAP_POI = 1664130579,
        GARR_MECHANIC = 1672086436,
        PVP_TALENT = 1672384929,
        BATTLE_PET_EFFECT_PROPERTIES = 1672791226,
        BONE_WIND_MODIFIERS = 1696199081,
        CHARACTER_LOADOUT_ITEM = 1707318183,
        RENOWN_REWARDS = 1710383997,
        LIQUID_TYPE = 1712570067,
        CREATURE_DISPLAY_INFO_EVT = 1716388118,
        SPELL_INTERRUPTS = 1720692227,
        ITEM_DISENCHANT_LOOT = 1722044526,
        CREATURE_DISPLAY_INFO_EXTRA = 1722140087,
        ARTIFACT_ITEM_TO_TRANSMOG = 1734716285,
        OBJECT_EFFECT = 1734738485,
        CHR_CUSTOMIZATION_CHOICE = 1746734909,
        SPELL_MISSILE = 1754233351,
        GARR_SITE_LEVEL_PLOT_INST = 1773314988,
        COMMENTATOR_START_LOCATION = 1792747342,
        BATTLE_PET_BREED_STATE = 1794847238,
        TRANSPORT_ANIMATION = 1805315045,
        AZERITE_ITEM_MILESTONE_POWER = 1807163031,
        ANIMA_MATERIAL = 1807341289,
        UI_EXPANSION_DISPLAY_INFO_ICON = 1815654866,
        CONFIGURATION_WARNING = 1819873442,
        BATTLE_PET_SPECIES = 1821637041,
        SPELL_CLUTTER_IMPACT_MODEL_COUNTS = 1821668294,
        SCREEN_LOCATION = 1824228575,
        GAME_OBJECT_DISPLAY_INFO = 1829768651,
        ZONE_STORY = 1834474139,
        KEY_CHAIN = 1837770388,
        RULESET_ITEM_UPGRADE = 1840711788,
        ENVIRONMENTAL_DAMAGE = 1851564952,
        ITEM_LEVEL_SELECTOR_QUALITY_SET = 1854254392,
        ITEM_CURRENCY_COST = 1876974313,
        ITEM_UPGRADE = 1879459387,
        CURVE_POINT = 1880017466,
        UI_WIDGET_MAP = 1886242059,
        ITEM_NAME_DESCRIPTION = 1891821565,
        JOURNAL_INSTANCE = 1899895961,
        CHR_CREATE_CLASS_ANIM_TARGET_INFO = 1903815414,
        ITEM_TO_BATTLE_PET_SPECIES = 1904564379,
        LFG_ROLE_REQUIREMENT = 1904724485,
        CHARACTER_LOADOUT_PET = 1909933589,
        CONDITIONAL_CONTENT_TUNING = 1913965383,
        TERRAIN_COLOR_GRADING_RAMP = 1917932763,
        AREA_TABLE = 1918102339,
        SPELL_MECHANIC = 1919757118,
        WIND_SETTINGS = 1924290945,
        SPELL_VISUAL_SCREEN_EFFECT = 1935318976,
        SPELL_EFFECT_CAMERA_SHAKES = 1939361897,
        VEHICLE_UI_IND_SEAT = 1939779537,
        GARR_PLOT_BUILDING = 1945261867,
        AZERITE_LEVEL_INFO = 1961916053,
        GUILD_SHIRT_BACKGROUND = 1964370948,
        HOLIDAYS = 1972272076,
        AZERITE_UNLOCK_MAPPING = 1979323873,
        SSAO_SETTINGS = 1987146010,
        GARR_FOLL_SUPPORT_SPELL = 1992065797,
        NPC_MODEL_ITEM_SLOT_DISPLAY_INFO = 1992314007,
        UI_QUEST_DETAILS_THEME = 1997265951,
        EMOTES_TEXT_DATA = 2003163239,
        GARR_ITEM_LEVEL_UPGRADE_DATA = 2008775392,
        ITEM_VISUALS = 2012662885,
        ITEM_FALLBACK_VISUAL = 2025598496,
        MAP_LOADING_SCREEN = 2029222119,
        MOUNT_X_DISPLAY = 2030087241,
        JOURNAL_ENCOUNTER_SECTION = 2035710060,
        QUEST_FEEDBACK_EFFECT = 2043095305,
        FACTION_GROUP = 2052437341,
        DESTRUCTIBLE_MODEL_DATA = 2054439517,
        CONTENT_TUNING_DESCRIPTION = 2059405375,
        TOY = 2063803484,
        CHAR_START_OUTFIT = 2067920257,
        ANIMA_CYLINDER = 2071061016,
        UI_TEXTURE_ATLAS_ELEMENT_OVERRIDE = 2074549115,
        PHASE_SHIFT_ZONE_SOUNDS = 2075223363,
        ITEM_LIMIT_CATEGORY = 2075795121,
        GUILD_TABARD_BORDER = 2095176905,
        SPELL_AURA_VIS_X_CHR_SPEC = 2096181888,
        ANIMA_CABLE = 2110109896,
        AREA_FAR_CLIP_OVERRIDE = 2119774942,
        MODIFIER_TREE = 2120822102,
        UI_SPLASH_SCREEN = 2121794349,
        GUILD_COLOR_BACKGROUND = 2122521976,
        SPELL_POWER_DIFFICULTY = 2124448848,
        SPELL_VISUAL_KIT_PICKER = 2124804047,
        CREATURE_MODEL_DATA = 2137612197,
        REWARD_PACK_X_ITEM = 2139595463,
        CHR_CUST_ITEM_GEO_MODIFY = 2141739000,
        SPELL_MISC_DIFFICULTY = 2143331989,
        COMMENTATOR_INDIRECT_SPELL = 2143604771,
        EDGE_GLOW_EFFECT = 2151089334,
        COMMUNITY_ICON = 2153586725,
        ITEM_DAMAGE_TWO_HAND_CASTER = 2158076154,
        ARTIFACT_TIER = 2162449480,
        PARTICULATE_SOUND = 2163447993,
        GROUND_EFFECT_TEXTURE = 2164840845,
        RESEARCH_PROJECT = 2169900995,
        VEHICLE_UI_INDICATOR = 2177964088,
        COMPONENT_TEXTURE_FILE_DATA = 2185268109,
        QUEST_X_GROUP_ACTIVITY = 2189163182,
        SCENARIO = 2198813286,
        ITEM_BONUS = 2199425034,
        QUEST_POI_POINT = 2202435563,
        GARR_TALENT_RANK = 2204349152,
        SPELL_ACTION_BAR_PREF = 2226175447,
        UI_MAP_GROUP_MEMBER = 2230237587,
        FILE_PATHS = 2235379829,
        FULL_SCREEN_EFFECT = 2235570485,
        CHAR_TITLES = 2246024846,
        ITEM_SET_SPELL = 2252716921,
        SOULBIND_CONDUIT_RANK_PROPERTIES = 2263604322,
        RUNEFORGE_LEGENDARY_ABILITY = 2268794270,
        WB_CERT_WHITELIST = 2287306173,
        CREATURE_DISPLAY_INFO_OPTION = 2294684390,
        ITEM_RANGED_DISPLAY_INFO = 2297086107,
        SOULBIND_CONDUIT = 2297557152,
        UI_WIDGET_SET = 2299908982,
        SD_REPLACEMENT_MODEL = 2302634121,
        UI_TEXTURE_ATLAS = 2303540067,
        GARR_MISSION_SET = 2303965254,
        GAME_TIPS = 2306351757,
        UI_MAP = 2308078583,
        SPELL_CLUTTER_WEAPON_TRAIL_DIST = 2314937013,
        SIEGEABLE_PROPERTIES = 2317973586,
        PVP_REWARD = 2333820745,
        ITEM_BONUS_LIST_GROUP_ENTRY = 2340571112,
        SOULBIND_CONDUIT_ENHANCED_SOCKET = 2341120801,
        WORLD_MAP_CONTINENT = 2345870169,
        LIQUID_MATERIAL = 2352452393,
        WAYPOINT_NODE = 2352705938,
        ITEM_APPEARANCE_X_UI_CAMERA = 2352874699,
        UI_CHROMIE_TIME_EXPANSION_INFO = 2356471694,
        AOI_BOX = 2360485552,
        QUEST_LINE_X_QUEST = 2361489494,
        POWER_TYPE = 2374605399,
        UI_WIDGET = 2381039112,
        GLYPH_REQUIRED_SPEC = 2385530453,
        ITEM_SET = 2389973656,
        SOUND_OVERRIDE = 2390774732,
        RIBBON_QUALITY = 2391114038,
        ADVENTURE_JOURNAL = 2398034583,
        RELIC_SLOT_TIER_REQUIREMENT = 2399360612,
        BARBER_SHOP_STYLE = 2399777931,
        TERRAIN_TYPE = 2402854065,
        BATTLE_PET_STATE = 2403627824,
        WATERFALL_DATA = 2405457343,
        WAYPOINT_SAFE_LOCS = 2411028436,
        HOTFIX = 2411921507,
        DUNGEON_MAP_CHUNK = 2412271734,
        QUEST_POI_POINT_CLI_TASK = 2412384869,
        DISSOLVE_EFFECT = 2413480372,
        SOULBIND = 2415589626,
        GM_SURVEY_CURRENT_SURVEY = 2423343561,
        ALLIED_RACE_RACIAL_ABILITY = 2429728272,
        MOUNT_X_SPELL_VISUAL_KIT_PICKER = 2431200605,
        GARR_FOLLOWER_X_ABILITY = 2437774747,
        ITEM_SPARSE = 2442913102,
        SPAM_MESSAGES = 2443936038,
        RESISTANCES = 2444969254,
        CREATURE_SOUND_DATA = 2445379776,
        WEEKLY_REWARD_CHEST_THRESHOLD = 2449433281,
        MAP_DIFFICULTY = 2456155917,
        ITEM_VISUAL_EFFECTS = 2456590174,
        CHR_CUSTOMIZATION_CONVERSION = 2465876050,
        AREA_TRIGGER_SPHERE = 2466724645,
        LOCK_TYPE = 2471080772,
        CHR_CUSTOMIZATION_COND_MODEL = 2486191968,
        GARR_BUILDING_PLOT_INST = 2494151198,
        PATH = 2499044245,
        TEXTURE_BLEND_SET = 2512539351,
        ITEM_SUB_CLASS = 2513986447,
        ITEM_BONUS_LIST = 2518885667,
        TRANSPORT_ROTATION = 2521134397,
        MAP_CELESTIAL_BODY = 2523168314,
        SCENARIO_STEP = 2523372402,
        MOUNT = 2524150337,
        COVENANT = 2525310038,
        ITEM_CONTEXT_PICKER_ENTRY = 2527642838,
        UI_MODEL_SCENE_CAMERA = 2533050585,
        SCHEDULED_WORLD_STATE_X_UNIQ_CAT = 2534865996,
        IMPORT_PRICE_WEAPON = 2540474264,
        ITEM_DAMAGE_AMMO = 2542846702,
        ITEM_DISPLAY_INFO = 2557447376,
        WORLD_CHUNK_SOUNDS = 2572780382,
        LFG_DUNGEONS = 2577119682,
        CHR_UPGRADE_TIER = 2583026706,
        CHR_CUSTOMIZATION_REQ_CHOICE = 2602298952,
        RTPC = 2611776361,
        GEM_PROPERTIES = 2617305709,
        RESEARCH_SITE = 2620501600,
        UI_MAP_ART_TILE = 2625553737,
        BROADCAST_TEXT_VO_STATE = 2625859240,
        ANIMATION_DATA = 2628737569,
        CAMERA_EFFECT_ENTRY = 2638339590,
        GARR_TALENT_TREE = 2640972154,
        SPELL_EFFECT_SCALING = 2645418034,
        GARR_FOLLOWER_UI_CREATURE = 2652491012,
        BARRAGE_EFFECT = 2656024449,
        GARR_BUILDING_DOODAD_SET = 2663146609,
        GARR_ENCOUNTER_SET_X_ENCOUNTER = 2666936164,
        ITEM_GROUP_SOUNDS = 2671904457,
        CHR_SPECIALIZATION = 2685374048,
        WEAPON_TRAIL_MODEL_DEF = 2699506049,
        MODEL_FILE_DATA = 2707547180,
        SOUND_FILTER_ELEM = 2709496350,
        SPELL_POWER = 2712461791,
        MARKETING_PROMOTIONS_X_LOCALE = 2715021741,
        ALLIED_RACE = 2752485560,
        GARR_ABILITY_EFFECT = 2753361231,
        WEAPON_TRAIL = 2753853165,
        AZERITE_ESSENCE = 2756140475,
        DECLINED_WORD_CASES = 2756270666,
        CHR_CUST_CLIENT_CHOICE_CONVERSION = 2756468502,
        MATERIAL = 2764116073,
        SPELL_TOTEMS = 2769259057,
        WORLD_SAFE_LOCS = 2769561834,
        PVP_SEASON = 2770180609,
        GROUND_EFFECT_DOODAD = 2777963210,
        ITEM_BONUS_TREE_NODE = 2793276977,
        VIRTUAL_ATTACHMENT_CUSTOMIZATION = 2797144087,
        GARR_ENCOUNTER = 2807278738,
        CHAR_COMPONENT_TEXTURE_LAYOUTS = 2809937531,
        CFG_REGIONS = 2810085133,
        CHAR_SHIPMENT_CONTAINER = 2810793959,
        TOTEM_CATEGORY = 2812474010,
        CHR_RACE_X_CHR_MODEL = 2816561406,
        CREATURE_DISPLAY_INFO_GEOSET_DATA = 2821573772,
        JOURNAL_ENCOUNTER_X_DIFFICULTY = 2822457430,
        ANIM_KIT_BONE_SET = 2827780344,
        GARR_FOLLOWER = 2832751941,
        GARR_MECHANIC_TYPE = 2837408936,
        PARTICULATE = 2840750588,
        WAYPOINT_EDGE = 2855597872,
        MULTI_TRANSITION_PROPERTIES = 2862018802,
        TAXI_PATH = 2872091740,
        SPELL_REAGENTS = 2875640223,
        SPELL_RADIUS = 2877179969,
        AZERITE_POWER = 2881046338,
        WORLD_MAP_OVERLAY_TILE = 2891552549,
        AREA_TRIGGER_CYLINDER = 2895307949,
        ARTIFACT_APPEARANCE = 2900396775,
        JOURNAL_ENCOUNTER_CREATURE = 2901650891,
        SHADOWY_EFFECT = 2913784219,
        UI_MAP_X_MAP_ART = 2914253964,
        PAPER_DOLL_ITEM_FRAME = 2916845724,
        AZERITE_TIER_UNLOCK_SET = 2920527329,
        QUEST_POI_BLOB = 2921112328,
        WEAPON_IMPACT_SOUNDS = 2921579418,
        CHAR_SECTION_CONDITION = 2929178302,
        UI_MODEL_SCENE_ACTOR = 2930840720,
        STATIONERY = 2936914515,
        GLOBAL_PLAYER_CONDITION_SET = 2937765539,
        ROPE_EFFECT = 2938440853,
        GROUP_FINDER_ACTIVITY = 2939349194,
        TRANSMOG_DEFAULT_LEVEL = 2944519526,
        SPELL_SPECIAL_UNIT_EFFECT = 2947410228,
        AZERITE_EMPOWERED_ITEM = 2947659279,
        TACT_KEY_LOOKUP = 2948698321,
        WORLD_PVP_AREA = 2950844250,
        CHAR_SHIPMENT = 2956113239,
        CHR_CLASS_UI_DISPLAY = 2967626539,
        CORRUPTION_EFFECTS = 2978956475,
        ARMOR_LOCATION = 2979075396,
        WMO_MINIMAP_TEXTURE = 2982519032,
        PVP_SEASON_REWARD_LEVELS = 2990665735,
        GARR_AUTO_COMBATANT = 2994259071,
        SCHEDULED_INTERVAL = 2998606315,
        SCREEN_EFFECT = 3007265124,
        ANIM_KIT = 3014618826,
        SPELL_DURATION = 3022256762,
        ITEM_BONUS_SEQUENCE_SPELL = 3026659740,
        UI_WIDGET_DATA_SOURCE = 3031818311,
        SPELL_FLYOUT = 3032234982,
        TRADE_SKILL_ITEM = 3037505077,
        UI_TEXTURE_ATLAS_MEMBER = 3039853142,
        SKILL_LINE = 3040725462,
        CHR_CUSTOMIZATION_MATERIAL = 3045950707,
        GLOBAL_PLAYER_CONDITION = 3052650033,
        UI_WIDGET_CONSTANT_SOURCE = 3072882582,
        MAP_DIFFICULTY_X_CONDITION = 3080893373,
        CONTRIBUTION_STYLE = 3084806990,
        UI_MAP_FOG_OF_WAR = 3086822848,
        MOVIE_FILE_DATA = 3098975037,
        DURABILITY_COSTS = 3100520987,
        AUCTION_HOUSE = 3103351894,
        OUTLINE_EFFECT = 3107997358,
        ITEM_ARMOR_QUALITY = 3108657159,
        PLAYER_CONDITION = 3108775943,
        ITEM_CLASS = 3111593758,
        SPELL_FOCUS_OBJECT = 3114120978,
        UI_MAP_POI = 3126592347,
        MULTI_STATE_PROPERTIES = 3127342046,
        SPELL_AURA_RESTRICTIONS = 3130494798,
        SOUND_PROVIDER_PREFERENCES = 3131514536,
        CHR_CUSTOMIZATION_CATEGORY = 3136120098,
        GARR_MISSION_X_FOLLOWER = 3144235570,
        ITEM_EXTENDED_COST = 3146089301,
        SPELL_SHAPESHIFT = 3163679255,
        GARR_TALENT_SOCKET_PROPERTIES = 3168814702,
        SPELL_OVERRIDE_NAME = 3169498630,
        SERVER_MESSAGES = 3172303717,
        CONTENT_TUNING = 3174446591,
        MAP = 3179597154,
        GLOBAL_TABLE_PLAYER_CONDITION = 3182410553,
        COMPONENT_MODEL_FILE_DATA = 3194678566,
        CHR_CLASS_UI_CHR_MODEL_INFO = 3198392456,
        CHR_CUSTOMIZATION_BONE_SET = 3204974385,
        GLOBAL_STRINGS = 3205218938,
        QUEST_FACTION_REWARD = 3216535624,
        GARR_FOLLOWER_TYPE = 3217892214,
        CREATURE_DISPLAY_INFO = 3218799089,
        CHR_CLASSES_X_POWER_TYPES = 3224459983,
        GUILD_TABARD_BACKGROUND = 3225663408,
        SOUND_KIT_ADVANCED = 3232102598,
        CHR_CLASS_TITLE = 3235645495,
        GAME_CLOCK_DEBUG = 3238770177,
        SCENARIO_EVENT_ENTRY = 3247720076,
        GLOBAL_GAME_CONTENT_TUNING = 3253299078,
        GARR_FOLLOWER_SET_X_FOLLOWER = 3253909153,
        SOUND_KIT_ENTRY = 3266400455,
        CINEMATIC_CAMERA = 3268345337,
        KEYSTONE_AFFIX = 3269690597,
        WEATHER = 3271961498,
        SPELL_EFFECT_EMISSION = 3274165704,
        GARR_MSSN_BONUS_ABILITY = 3275136485,
        BATTLE_PET_VISUAL = 3282955075,
        ARTIFACT_CATEGORY = 3312628869,
        SPELL_MISC = 3322146344,
        SOUND_EMITTERS = 3325606100,
        CHR_UPGRADE_BUCKET_SPELL = 3326241424,
        SOUND_PARAMETER = 3328156536,
        LIGHT_PARAMS = 3330215320,
        CHR_MODEL_TEXTURE_TARGET = 3338806786,
        WMO_AREA_TABLE = 3343891947,
        CONVERSATION_LINE = 3348406326,
        WORLD_ELAPSED_TIMER = 3349771169,
        DECAL_PROPERTIES = 3350717493,
        CFG_CATEGORIES = 3354229117,
        CONTENT_TUNING_X_EXPECTED_STAT_MOD = 3354453880,
        WEAPON_SWING_SOUNDS2 = 3356076557,
        WORLD_STATE = 3359787322,
        OCCLUDER_CURTAIN = 3370922724,
        PATH_EDGE = 3384586280,
        CREATURE = 3386291891,
        CREATURE_DIFFICULTY = 3386943305,
        MODIFIED_CRAFTING_SPELL_SLOT = 3388959798,
        ARTIFACT_QUEST_XP = 3392267897,
        OVERRIDE_SPELL_DATA = 3396722460,
        PVP_DIFFICULTY = 3397665861,
        OBJECT_EFFECT_PACKAGE_ELEM = 3408032706,
        DIFFICULTY = 3408494138,
        BATTLE_PET_ABILITY = 3416538071,
        BOUNTY_SET = 3419578634,
        SPELL_VISUAL_EVENT = 3425193231,
        QUEST_PACKAGE_ITEM = 3425666288,
        CHAT_CHANNELS = 3439298541,
        JOURNAL_ENCOUNTER_X_MAP_LOC = 3445057282,
        BATTLE_PET_DISPLAY_OVERRIDE = 3448812934,
        WB_CERT_BLACKLIST = 3450573023,
        SCENE_SCRIPT_GLOBAL_TEXT = 3470338199,
        REWARD_PACK = 3472385212,
        QUEST_MONEY_REWARD = 3473498257,
        CREATURE_MOVEMENT_INFO = 3474286469,
        GARR_TALENT_COST = 3479059991,
        DEVICE_DEFAULT_SETTINGS = 3490179113,
        TRANSPORT_PHYSICS = 3494282461,
        SPELL_PROCS_PER_MINUTE = 3497430124,
        SPELL_FLYOUT_ITEM = 3502171243,
        SPELL_CATEGORY = 3502494094,
        GARR_AUTO_SPELL = 3503073706,
        GARR_TYPE = 3513414411,
        PVP_SCALING_EFFECT = 3517652874,
        SPELL_CLUTTER_KIT_DISTANCES = 3518655980,
        PAGE_TEXT_MATERIAL = 3527639455,
        ACHIEVEMENT = 3538824359,
        AZERITE_KNOWLEDGE_MULTIPLIER = 3540944148,
        LIGHT_SKYBOX = 3546600791,
        CURRENCY_CATEGORY = 3552864641,
        REWARD_PACK_X_CURRENCY_TYPE = 3554473599,
        UI_ITEM_INTERACTION = 3554907282,
        SOULBIND_CONDUIT_RANK = 3557796329,
        VEHICLE_SEAT = 3567803627,
        SCENE_SCRIPT = 3568395212,
        SPELL_KEYBOUND_OVERRIDE = 3568717261,
        UNIT_TEST = 3571051513,
        AREA_TRIGGER_CREATE_PROPERTIES = 3571931810,
        SKY_SCENE_X_PLAYER_CONDITION = 3596755396,
        GAME_OBJECT_ANIM_GROUP_MEMBER = 3598230279,
        RAF_ACTIVITY = 3603302088,
        CHR_CUSTOMIZATION_ELEMENT = 3603976684,
        LFG_DUNGEONS_GROUPING_MAP = 3604091206,
        ITEM_NAME_SLOT_OVERRIDE = 3617318160,
        ITEM_LIMIT_CATEGORY_CONDITION = 3624436720,
        LORE_TEXT = 3628973429,
        SOUND_EMITTER_PILL_POINTS = 3634485004,
        ITEM_DAMAGE_TWO_HAND = 3636854083,
        GARR_MISSION_TYPE = 3638153752,
        ITEM_MODIFIED_APPEARANCE_EXTRA = 3645674820,
        CAMPAIGN = 3656496423,
        WORLD_EFFECT = 3664936999,
        NAMES_PROFANITY = 3666008428,
        GARR_CLASS_SPEC_PLAYER_COND = 3674323042,
        GAME_OBJECT_DISPLAY_INFO_X_SOUND_KIT = 3676568537,
        BROADCAST_TEXT_DURATION = 3678427948,
        GUILD_TABARD_EMBLEM = 3681746698,
        UNIT_BLOOD = 3682280824,
        SPELL_CATEGORIES = 3689412649,
        SPELL_LEARN_SPELL = 3689805315,
        CLOAK_DAMPENING = 3703971568,
        ITEM_VISUALS_X_EFFECT = 3707077315,
        SPELL_CRAFT_UI = 3707100876,
        SOULBIND_UI_DISPLAY_INFO = 3707428843,
        PVP_SCOREBOARD_CELL_INFO = 3716153855,
        BATTLE_PET_ABILITY_EFFECT = 3716901134,
        CHR_UPGRADE_BUCKET = 3720095159,
        TIER_TRANSITION = 3721847315,
        RESEARCH_FIELD = 3722626511,
        GARR_FOLLOWER_LEVEL_XP = 3727959107,
        BANK_BAG_SLOT_PRICES = 3740031584,
        TACT_KEY = 3744420815,
        AREA_POI = 3745449290,
        VOLUME_FOG_CONDITION = 3747714704,
        GOSSIP_XUI_DISPLAY_INFO = 3748948075,
        CHARACTER_LOADOUT = 3758770171,
        SPELL_RANGE = 3763447452,
        SPELL_ITEM_ENCHANTMENT = 3764045193,
        SPELL_TARGET_RESTRICTIONS = 3764692828,
        ITEM_DAMAGE_ONE_HAND = 3769023240,
        SPELL = 3776013982,
        GLYPH_EXCLUSIVE_CATEGORY = 3777145859,
        CONTENT_TUNING_X_EXPECTED = 3797052681,
        MAIL_TEMPLATE = 3821385681,
        CHAR_START_KIT = 3823348798,
        SPELL_EQUIPPED_ITEMS = 3830102996,
        SCENE_SCRIPT_PACKAGE_MEMBER = 3830298396,
        GARR_ABILITY = 3832747704,
        ITEM_MODIFIED_APPEARANCE = 3834752085,
        GARR_STRING = 3841641018,
        MANIFEST_INTERFACE_TOC_DATA = 3843019564,
        LIGHTNING = 3851703667,
        ITEM_DISPLAY_X_UI_CAMERA = 3851893958,
        MODIFIED_CRAFTING_REAGENT_ITEM = 3851993221,
        TAXI_PATH_NODE = 3857287356,
        ITEM_SUB_CLASS_MASK = 3857758069,
        UI_COVENANT_DISPLAY_INFO = 3863664554,
        MODIFIED_REAGENT_ITEM = 3865974254,
        CLONE_EFFECT = 3866191592,
        ITEM_RANDOM_SUFFIX = 3867218247,
        LOADING_SCREEN_TAXI_SPLINES = 3870173959,
        ARTIFACT_APPEARANCE_SET = 3876723617,
        GLOBAL_CURVE = 3884084876,
        MANAGED_WORLD_STATE_BUFF = 3888123285,
        AZERITE_TIER_UNLOCK = 3893100071,
        MYTHIC_PLUS_SEASON_REWARD_LEVELS = 3893700160,
        LANGUAGE_WORDS = 3897115516,
        CRITERIA_TREE_X_EFFECT = 3898252553,
        SPELL_AURA_VISIBILITY = 3899321669,
        PARTICLE_COLOR = 3902533594,
        SCENE_SCRIPT_PACKAGE = 3905641993,
        CHR_CUSTOMIZATION = 3911421194,
        SKILL_LINE_CATEGORY = 3912239786,
        ANIM_REPLACEMENT_SET = 3916479355,
        SOUND_KIT_FALLBACK = 3917681400,
        LOCK = 3921595171,
        SPELL_PROCS_PER_MINUTE_MOD = 3945052460,
        QUEST_LINE = 3948389411,
        BATTLE_PET_SPECIES_X_COVENANT = 3949627620,
        SPELL_EFFECT_AUTO_DESCRIPTION = 3950590001,
        PVP_TIER = 3956697354,
        BATTLE_PET_ABILITY_TURN = 3973639388,
        EMOTES_TEXT = 3981346648,
        CHR_CUSTOMIZATION_DISPLAY_INFO = 3994791772,
        CRITERIA = 4012104832,
        LOADING_SCREENS = 4020094719,
        VIGNETTE = 4021368146,
        SPELL_EFFECT = 4030871717,
        SPELL_VISUAL_KIT_MODEL_ATTACH = 4033975491,
        PHASE = 4040235363,
        MANAGED_WORLD_STATE = 4046269067,
        ITEM_LEVEL_SELECTOR_QUALITY = 4046816394,
        TROPHY = 4047189852,
        LFG_DUNGEON_EXPANSION = 4060071752,
        BATTLE_PET_NPC_TEAM_MEMBER = 4060454394,
        MODIFIED_CRAFTING_CATEGORY = 4064901541,
        ITEM_DAMAGE_ONE_HAND_CASTER = 4069992295,
        ZONE_MUSIC = 4071081280,
        ITEM_LEVEL_SELECTOR = 4072756116,
        ITEM_DISPLAY_INFO_MATERIAL_RES = 4082824155,
        ARTIFACT_POWER = 4088109130,
        LANGUAGES = 4090750226,
        SPELL_X_DESCRIPTION_VARIABLES = 4091125549,
        TERRAIN_TYPE_SOUNDS = 4092287527,
        GARR_PLOT_INSTANCE = 4093144214,
        WORLD_BOSS_LOCKOUT = 4095124812,
        SPELL_CLUTTER_MISSILE_DIST = 4096287001,
        SPELL_AURA_OPTIONS = 4096770149,
        PVP_SCOREBOARD_LAYOUT = 4102026799,
        SPELL_VISUAL_KIT = 4102286043,
        CHR_CLASSES = 4119371148,
        NAME_GEN = 4126835867,
        MOUNT_CAPABILITY = 4134404214,
        UI_CAMERA = 4138277569,
        SPELL_PROCEDURAL_EFFECT = 4139550175,
        CLIENT_SCENE_EFFECT = 4144267057,
        SPELL_VISUAL = 4146370265,
        CASTABLE_RAID_BUFFS = 4147515750,
        UI_WIDGET_VISUALIZATION = 4150907485,
        DURABILITY_QUALITY = 4152396805,
        PVP_BRACKET_TYPES = 4152856833,
        JOURNAL_ENCOUNTER_ITEM = 4159531103,
        WB_PERMISSIONS = 4163366139,
        SPELL_ACTIVATION_OVERLAY = 4167587713,
        AZERITE_ITEM = 4173050997,
        GARR_AUTO_SPELL_EFFECT = 4178530505,
        SPELL_ITEM_ENCHANTMENT_CONDITION = 4182849840,
        SPELL_SHAPESHIFT_FORM = 4182948165,
        PVP_ITEM = 4187421273,
        TALENT = 4188284511,
        SPELL_COOLDOWNS = 4193483863,
        CHR_MODEL_MATERIAL = 4202864674,
        CHAR_COMPONENT_TEXTURE_SECTIONS = 4205415669,
        GLYPH_PROPERTIES = 4210316457,
        STARTUP_STRINGS = 4211496909,
        MOUNT_EQUIPMENT = 4216221329,
        DUNGEON_ENCOUNTER = 4218319612,
        RTPC_DATA = 4229079558,
        EXTRA_ABILITY_INFO = 4230586375,
        LIQUID_OBJECT = 4230614527,
        MAW_POWER = 4232160649,
        RELIC_TALENT = 4234942376,
        CREATURE_DISPLAY_INFO_TRN = 4245272579,
        CAMERA_MODE = 4253494973,
        SPELL_CAST_TIMES = 4256848486,
        PATH_NODE_PROPERTY = 4263624740,
        GM_SURVEY_QUESTIONS = 4272931257,
        MANIFEST_INTERFACE_DATA = 4273710460,
        SPELL_EFFECT_EXTRA = 4278057076,
        SKILL_LINE_ABILITY = 4282664694,
        ITEM_ARMOR_SHIELD = 4290481602
    }
}
