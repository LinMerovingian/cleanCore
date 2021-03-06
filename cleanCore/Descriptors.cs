﻿// Version: 4.0.3  Build number: 13329  Build date: Nov 17 2010



namespace cleanCore
{
    // Descriptors: 0x00C144D0
    public enum ObjectField : uint
    {
        OBJECT_FIELD_GUID = 0x0,
        OBJECT_FIELD_TYPE = 0x8,
        OBJECT_FIELD_ENTRY = 0xC,
        OBJECT_FIELD_SCALE_X = 0x10,
        OBJECT_FIELD_DATA = 0x14,
        OBJECT_FIELD_PADDING = 0x1C,
        OBJECT_END = 0x20
    }

    // Descriptors: 0x00C148D0
    public enum UnitField : uint
    {
        UNIT_FIELD_CHARM = ObjectField.OBJECT_END + 0x0,
        UNIT_FIELD_SUMMON = ObjectField.OBJECT_END + 0x8,
        UNIT_FIELD_CRITTER = ObjectField.OBJECT_END + 0x10,
        UNIT_FIELD_CHARMEDBY = ObjectField.OBJECT_END + 0x18,
        UNIT_FIELD_SUMMONEDBY = ObjectField.OBJECT_END + 0x20,
        UNIT_FIELD_CREATEDBY = ObjectField.OBJECT_END + 0x28,
        UNIT_FIELD_TARGET = ObjectField.OBJECT_END + 0x30,
        UNIT_FIELD_CHANNEL_OBJECT = ObjectField.OBJECT_END + 0x38,
        UNIT_CHANNEL_SPELL = ObjectField.OBJECT_END + 0x40,
        UNIT_FIELD_BYTES_0 = ObjectField.OBJECT_END + 0x44,
        UNIT_FIELD_HEALTH = ObjectField.OBJECT_END + 0x48,
        UNIT_FIELD_POWER1 = ObjectField.OBJECT_END + 0x4C,
        UNIT_FIELD_POWER2 = ObjectField.OBJECT_END + 0x50,
        UNIT_FIELD_POWER3 = ObjectField.OBJECT_END + 0x54,
        UNIT_FIELD_POWER4 = ObjectField.OBJECT_END + 0x58,
        UNIT_FIELD_POWER5 = ObjectField.OBJECT_END + 0x5C,
        UNIT_FIELD_POWER6 = ObjectField.OBJECT_END + 0x60,
        UNIT_FIELD_POWER7 = ObjectField.OBJECT_END + 0x64,
        UNIT_FIELD_POWER8 = ObjectField.OBJECT_END + 0x68,
        UNIT_FIELD_POWER9 = ObjectField.OBJECT_END + 0x6C,
        UNIT_FIELD_POWER10 = ObjectField.OBJECT_END + 0x70,
        UNIT_FIELD_POWER11 = ObjectField.OBJECT_END + 0x74,
        UNIT_FIELD_MAXHEALTH = ObjectField.OBJECT_END + 0x78,
        UNIT_FIELD_MAXPOWER1 = ObjectField.OBJECT_END + 0x7C,
        UNIT_FIELD_MAXPOWER2 = ObjectField.OBJECT_END + 0x80,
        UNIT_FIELD_MAXPOWER3 = ObjectField.OBJECT_END + 0x84,
        UNIT_FIELD_MAXPOWER4 = ObjectField.OBJECT_END + 0x88,
        UNIT_FIELD_MAXPOWER5 = ObjectField.OBJECT_END + 0x8C,
        UNIT_FIELD_MAXPOWER6 = ObjectField.OBJECT_END + 0x90,
        UNIT_FIELD_MAXPOWER7 = ObjectField.OBJECT_END + 0x94,
        UNIT_FIELD_MAXPOWER8 = ObjectField.OBJECT_END + 0x98,
        UNIT_FIELD_MAXPOWER9 = ObjectField.OBJECT_END + 0x9C,
        UNIT_FIELD_MAXPOWER10 = ObjectField.OBJECT_END + 0xA0,
        UNIT_FIELD_MAXPOWER11 = ObjectField.OBJECT_END + 0xA4,
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER = ObjectField.OBJECT_END + 0xA8,
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER = ObjectField.OBJECT_END + 0xD4,
        UNIT_FIELD_LEVEL = ObjectField.OBJECT_END + 0x100,
        UNIT_FIELD_FACTIONTEMPLATE = ObjectField.OBJECT_END + 0x104,
        UNIT_VIRTUAL_ITEM_SLOT_ID = ObjectField.OBJECT_END + 0x108,
        UNIT_FIELD_FLAGS = ObjectField.OBJECT_END + 0x114,
        UNIT_FIELD_FLAGS_2 = ObjectField.OBJECT_END + 0x118,
        UNIT_FIELD_AURASTATE = ObjectField.OBJECT_END + 0x11C,
        UNIT_FIELD_BASEATTACKTIME = ObjectField.OBJECT_END + 0x120,
        UNIT_FIELD_RANGEDATTACKTIME = ObjectField.OBJECT_END + 0x128,
        UNIT_FIELD_BOUNDINGRADIUS = ObjectField.OBJECT_END + 0x12C,
        UNIT_FIELD_COMBATREACH = ObjectField.OBJECT_END + 0x130,
        UNIT_FIELD_DISPLAYID = ObjectField.OBJECT_END + 0x134,
        UNIT_FIELD_NATIVEDISPLAYID = ObjectField.OBJECT_END + 0x138,
        UNIT_FIELD_MOUNTDISPLAYID = ObjectField.OBJECT_END + 0x13C,
        UNIT_FIELD_MINDAMAGE = ObjectField.OBJECT_END + 0x140,
        UNIT_FIELD_MAXDAMAGE = ObjectField.OBJECT_END + 0x144,
        UNIT_FIELD_MINOFFHANDDAMAGE = ObjectField.OBJECT_END + 0x148,
        UNIT_FIELD_MAXOFFHANDDAMAGE = ObjectField.OBJECT_END + 0x14C,
        UNIT_FIELD_BYTES_1 = ObjectField.OBJECT_END + 0x150,
        UNIT_FIELD_PETNUMBER = ObjectField.OBJECT_END + 0x154,
        UNIT_FIELD_PET_NAME_TIMESTAMP = ObjectField.OBJECT_END + 0x158,
        UNIT_FIELD_PETEXPERIENCE = ObjectField.OBJECT_END + 0x15C,
        UNIT_FIELD_PETNEXTLEVELEXP = ObjectField.OBJECT_END + 0x160,
        UNIT_DYNAMIC_FLAGS = ObjectField.OBJECT_END + 0x164,
        UNIT_MOD_CAST_SPEED = ObjectField.OBJECT_END + 0x168,
        UNIT_CREATED_BY_SPELL = ObjectField.OBJECT_END + 0x16C,
        UNIT_NPC_FLAGS = ObjectField.OBJECT_END + 0x170,
        UNIT_NPC_EMOTESTATE = ObjectField.OBJECT_END + 0x174,
        UNIT_FIELD_STAT0 = ObjectField.OBJECT_END + 0x178,
        UNIT_FIELD_STAT1 = ObjectField.OBJECT_END + 0x17C,
        UNIT_FIELD_STAT2 = ObjectField.OBJECT_END + 0x180,
        UNIT_FIELD_STAT3 = ObjectField.OBJECT_END + 0x184,
        UNIT_FIELD_STAT4 = ObjectField.OBJECT_END + 0x188,
        UNIT_FIELD_POSSTAT0 = ObjectField.OBJECT_END + 0x18C,
        UNIT_FIELD_POSSTAT1 = ObjectField.OBJECT_END + 0x190,
        UNIT_FIELD_POSSTAT2 = ObjectField.OBJECT_END + 0x194,
        UNIT_FIELD_POSSTAT3 = ObjectField.OBJECT_END + 0x198,
        UNIT_FIELD_POSSTAT4 = ObjectField.OBJECT_END + 0x19C,
        UNIT_FIELD_NEGSTAT0 = ObjectField.OBJECT_END + 0x1A0,
        UNIT_FIELD_NEGSTAT1 = ObjectField.OBJECT_END + 0x1A4,
        UNIT_FIELD_NEGSTAT2 = ObjectField.OBJECT_END + 0x1A8,
        UNIT_FIELD_NEGSTAT3 = ObjectField.OBJECT_END + 0x1AC,
        UNIT_FIELD_NEGSTAT4 = ObjectField.OBJECT_END + 0x1B0,
        UNIT_FIELD_RESISTANCES = ObjectField.OBJECT_END + 0x1B4,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = ObjectField.OBJECT_END + 0x1D0,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = ObjectField.OBJECT_END + 0x1EC,
        UNIT_FIELD_BASE_MANA = ObjectField.OBJECT_END + 0x208,
        UNIT_FIELD_BASE_HEALTH = ObjectField.OBJECT_END + 0x20C,
        UNIT_FIELD_BYTES_2 = ObjectField.OBJECT_END + 0x210,
        UNIT_FIELD_ATTACK_POWER = ObjectField.OBJECT_END + 0x214,
        UNIT_FIELD_ATTACK_POWER_MOD_POS = ObjectField.OBJECT_END + 0x218,
        UNIT_FIELD_ATTACK_POWER_MOD_NEG = ObjectField.OBJECT_END + 0x21C,
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER = ObjectField.OBJECT_END + 0x220,
        UNIT_FIELD_RANGED_ATTACK_POWER = ObjectField.OBJECT_END + 0x224,
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_POS = ObjectField.OBJECT_END + 0x228,
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_NEG = ObjectField.OBJECT_END + 0x22C,
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = ObjectField.OBJECT_END + 0x230,
        UNIT_FIELD_MINRANGEDDAMAGE = ObjectField.OBJECT_END + 0x234,
        UNIT_FIELD_MAXRANGEDDAMAGE = ObjectField.OBJECT_END + 0x238,
        UNIT_FIELD_POWER_COST_MODIFIER = ObjectField.OBJECT_END + 0x23C,
        UNIT_FIELD_POWER_COST_MULTIPLIER = ObjectField.OBJECT_END + 0x258,
        UNIT_FIELD_MAXHEALTHMODIFIER = ObjectField.OBJECT_END + 0x274,
        UNIT_FIELD_HOVERHEIGHT = ObjectField.OBJECT_END + 0x278,
        UNIT_FIELD_MAXITEMLEVEL = ObjectField.OBJECT_END + 0x27C,
        UNIT_END = ObjectField.OBJECT_END + 0x280
    }

    // Descriptors: 0x00C14548
    public enum ItemField : uint
    {
        ITEM_FIELD_OWNER = ObjectField.OBJECT_END + 0x0,
        ITEM_FIELD_CONTAINED = ObjectField.OBJECT_END + 0x8,
        ITEM_FIELD_CREATOR = ObjectField.OBJECT_END + 0x10,
        ITEM_FIELD_GIFTCREATOR = ObjectField.OBJECT_END + 0x18,
        ITEM_FIELD_STACK_COUNT = ObjectField.OBJECT_END + 0x20,
        ITEM_FIELD_DURATION = ObjectField.OBJECT_END + 0x24,
        ITEM_FIELD_SPELL_CHARGES = ObjectField.OBJECT_END + 0x28,
        ITEM_FIELD_FLAGS = ObjectField.OBJECT_END + 0x3C,
        ITEM_FIELD_ENCHANTMENT_1_1 = ObjectField.OBJECT_END + 0x40,
        ITEM_FIELD_ENCHANTMENT_1_3 = ObjectField.OBJECT_END + 0x48,
        ITEM_FIELD_ENCHANTMENT_2_1 = ObjectField.OBJECT_END + 0x4C,
        ITEM_FIELD_ENCHANTMENT_2_3 = ObjectField.OBJECT_END + 0x54,
        ITEM_FIELD_ENCHANTMENT_3_1 = ObjectField.OBJECT_END + 0x58,
        ITEM_FIELD_ENCHANTMENT_3_3 = ObjectField.OBJECT_END + 0x60,
        ITEM_FIELD_ENCHANTMENT_4_1 = ObjectField.OBJECT_END + 0x64,
        ITEM_FIELD_ENCHANTMENT_4_3 = ObjectField.OBJECT_END + 0x6C,
        ITEM_FIELD_ENCHANTMENT_5_1 = ObjectField.OBJECT_END + 0x70,
        ITEM_FIELD_ENCHANTMENT_5_3 = ObjectField.OBJECT_END + 0x78,
        ITEM_FIELD_ENCHANTMENT_6_1 = ObjectField.OBJECT_END + 0x7C,
        ITEM_FIELD_ENCHANTMENT_6_3 = ObjectField.OBJECT_END + 0x84,
        ITEM_FIELD_ENCHANTMENT_7_1 = ObjectField.OBJECT_END + 0x88,
        ITEM_FIELD_ENCHANTMENT_7_3 = ObjectField.OBJECT_END + 0x90,
        ITEM_FIELD_ENCHANTMENT_8_1 = ObjectField.OBJECT_END + 0x94,
        ITEM_FIELD_ENCHANTMENT_8_3 = ObjectField.OBJECT_END + 0x9C,
        ITEM_FIELD_ENCHANTMENT_9_1 = ObjectField.OBJECT_END + 0xA0,
        ITEM_FIELD_ENCHANTMENT_9_3 = ObjectField.OBJECT_END + 0xA8,
        ITEM_FIELD_ENCHANTMENT_10_1 = ObjectField.OBJECT_END + 0xAC,
        ITEM_FIELD_ENCHANTMENT_10_3 = ObjectField.OBJECT_END + 0xB4,
        ITEM_FIELD_ENCHANTMENT_11_1 = ObjectField.OBJECT_END + 0xB8,
        ITEM_FIELD_ENCHANTMENT_11_3 = ObjectField.OBJECT_END + 0xC0,
        ITEM_FIELD_ENCHANTMENT_12_1 = ObjectField.OBJECT_END + 0xC4,
        ITEM_FIELD_ENCHANTMENT_12_3 = ObjectField.OBJECT_END + 0xCC,
        ITEM_FIELD_ENCHANTMENT_13_1 = ObjectField.OBJECT_END + 0xD0,
        ITEM_FIELD_ENCHANTMENT_13_3 = ObjectField.OBJECT_END + 0xD8,
        ITEM_FIELD_ENCHANTMENT_14_1 = ObjectField.OBJECT_END + 0xDC,
        ITEM_FIELD_ENCHANTMENT_14_3 = ObjectField.OBJECT_END + 0xE4,
        ITEM_FIELD_PROPERTY_SEED = ObjectField.OBJECT_END + 0xE8,
        ITEM_FIELD_RANDOM_PROPERTIES_ID = ObjectField.OBJECT_END + 0xEC,
        ITEM_FIELD_DURABILITY = ObjectField.OBJECT_END + 0xF0,
        ITEM_FIELD_MAXDURABILITY = ObjectField.OBJECT_END + 0xF4,
        ITEM_FIELD_CREATE_PLAYED_TIME = ObjectField.OBJECT_END + 0xF8,
        ITEM_FIELD_PAD = ObjectField.OBJECT_END + 0xFC,
        ITEM_END = ObjectField.OBJECT_END + 0x100
    }

    // Descriptors: 0x00C15090
    public enum PlayerField : uint
    {
        PLAYER_DUEL_ARBITER = UnitField.UNIT_END + 0x0,
        PLAYER_FLAGS = UnitField.UNIT_END + 0x8,
        PLAYER_GUILDRANK = UnitField.UNIT_END + 0xC,
        PLAYER_GUILDDELETE_DATE = UnitField.UNIT_END + 0x10,
        PLAYER_GUILDLEVEL = UnitField.UNIT_END + 0x14,
        PLAYER_BYTES = UnitField.UNIT_END + 0x18,
        PLAYER_BYTES_2 = UnitField.UNIT_END + 0x1C,
        PLAYER_BYTES_3 = UnitField.UNIT_END + 0x20,
        PLAYER_DUEL_TEAM = UnitField.UNIT_END + 0x24,
        PLAYER_GUILD_TIMESTAMP = UnitField.UNIT_END + 0x28,
        PLAYER_QUEST_LOG_1_1 = UnitField.UNIT_END + 0x2C,
        PLAYER_QUEST_LOG_1_2 = UnitField.UNIT_END + 0x30,
        PLAYER_QUEST_LOG_1_3 = UnitField.UNIT_END + 0x34,
        PLAYER_QUEST_LOG_1_4 = UnitField.UNIT_END + 0x3C,
        PLAYER_QUEST_LOG_2_1 = UnitField.UNIT_END + 0x40,
        PLAYER_QUEST_LOG_2_2 = UnitField.UNIT_END + 0x44,
        PLAYER_QUEST_LOG_2_3 = UnitField.UNIT_END + 0x48,
        PLAYER_QUEST_LOG_2_5 = UnitField.UNIT_END + 0x50,
        PLAYER_QUEST_LOG_3_1 = UnitField.UNIT_END + 0x54,
        PLAYER_QUEST_LOG_3_2 = UnitField.UNIT_END + 0x58,
        PLAYER_QUEST_LOG_3_3 = UnitField.UNIT_END + 0x5C,
        PLAYER_QUEST_LOG_3_5 = UnitField.UNIT_END + 0x64,
        PLAYER_QUEST_LOG_4_1 = UnitField.UNIT_END + 0x68,
        PLAYER_QUEST_LOG_4_2 = UnitField.UNIT_END + 0x6C,
        PLAYER_QUEST_LOG_4_3 = UnitField.UNIT_END + 0x70,
        PLAYER_QUEST_LOG_4_5 = UnitField.UNIT_END + 0x78,
        PLAYER_QUEST_LOG_5_1 = UnitField.UNIT_END + 0x7C,
        PLAYER_QUEST_LOG_5_2 = UnitField.UNIT_END + 0x80,
        PLAYER_QUEST_LOG_5_3 = UnitField.UNIT_END + 0x84,
        PLAYER_QUEST_LOG_5_5 = UnitField.UNIT_END + 0x8C,
        PLAYER_QUEST_LOG_6_1 = UnitField.UNIT_END + 0x90,
        PLAYER_QUEST_LOG_6_2 = UnitField.UNIT_END + 0x94,
        PLAYER_QUEST_LOG_6_3 = UnitField.UNIT_END + 0x98,
        PLAYER_QUEST_LOG_6_5 = UnitField.UNIT_END + 0xA0,
        PLAYER_QUEST_LOG_7_1 = UnitField.UNIT_END + 0xA4,
        PLAYER_QUEST_LOG_7_2 = UnitField.UNIT_END + 0xA8,
        PLAYER_QUEST_LOG_7_3 = UnitField.UNIT_END + 0xAC,
        PLAYER_QUEST_LOG_7_5 = UnitField.UNIT_END + 0xB4,
        PLAYER_QUEST_LOG_8_1 = UnitField.UNIT_END + 0xB8,
        PLAYER_QUEST_LOG_8_2 = UnitField.UNIT_END + 0xBC,
        PLAYER_QUEST_LOG_8_3 = UnitField.UNIT_END + 0xC0,
        PLAYER_QUEST_LOG_8_5 = UnitField.UNIT_END + 0xC8,
        PLAYER_QUEST_LOG_9_1 = UnitField.UNIT_END + 0xCC,
        PLAYER_QUEST_LOG_9_2 = UnitField.UNIT_END + 0xD0,
        PLAYER_QUEST_LOG_9_3 = UnitField.UNIT_END + 0xD4,
        PLAYER_QUEST_LOG_9_5 = UnitField.UNIT_END + 0xDC,
        PLAYER_QUEST_LOG_10_1 = UnitField.UNIT_END + 0xE0,
        PLAYER_QUEST_LOG_10_2 = UnitField.UNIT_END + 0xE4,
        PLAYER_QUEST_LOG_10_3 = UnitField.UNIT_END + 0xE8,
        PLAYER_QUEST_LOG_10_5 = UnitField.UNIT_END + 0xF0,
        PLAYER_QUEST_LOG_11_1 = UnitField.UNIT_END + 0xF4,
        PLAYER_QUEST_LOG_11_2 = UnitField.UNIT_END + 0xF8,
        PLAYER_QUEST_LOG_11_3 = UnitField.UNIT_END + 0xFC,
        PLAYER_QUEST_LOG_11_5 = UnitField.UNIT_END + 0x104,
        PLAYER_QUEST_LOG_12_1 = UnitField.UNIT_END + 0x108,
        PLAYER_QUEST_LOG_12_2 = UnitField.UNIT_END + 0x10C,
        PLAYER_QUEST_LOG_12_3 = UnitField.UNIT_END + 0x110,
        PLAYER_QUEST_LOG_12_5 = UnitField.UNIT_END + 0x118,
        PLAYER_QUEST_LOG_13_1 = UnitField.UNIT_END + 0x11C,
        PLAYER_QUEST_LOG_13_2 = UnitField.UNIT_END + 0x120,
        PLAYER_QUEST_LOG_13_3 = UnitField.UNIT_END + 0x124,
        PLAYER_QUEST_LOG_13_5 = UnitField.UNIT_END + 0x12C,
        PLAYER_QUEST_LOG_14_1 = UnitField.UNIT_END + 0x130,
        PLAYER_QUEST_LOG_14_2 = UnitField.UNIT_END + 0x134,
        PLAYER_QUEST_LOG_14_3 = UnitField.UNIT_END + 0x138,
        PLAYER_QUEST_LOG_14_5 = UnitField.UNIT_END + 0x140,
        PLAYER_QUEST_LOG_15_1 = UnitField.UNIT_END + 0x144,
        PLAYER_QUEST_LOG_15_2 = UnitField.UNIT_END + 0x148,
        PLAYER_QUEST_LOG_15_3 = UnitField.UNIT_END + 0x14C,
        PLAYER_QUEST_LOG_15_5 = UnitField.UNIT_END + 0x154,
        PLAYER_QUEST_LOG_16_1 = UnitField.UNIT_END + 0x158,
        PLAYER_QUEST_LOG_16_2 = UnitField.UNIT_END + 0x15C,
        PLAYER_QUEST_LOG_16_3 = UnitField.UNIT_END + 0x160,
        PLAYER_QUEST_LOG_16_5 = UnitField.UNIT_END + 0x168,
        PLAYER_QUEST_LOG_17_1 = UnitField.UNIT_END + 0x16C,
        PLAYER_QUEST_LOG_17_2 = UnitField.UNIT_END + 0x170,
        PLAYER_QUEST_LOG_17_3 = UnitField.UNIT_END + 0x174,
        PLAYER_QUEST_LOG_17_5 = UnitField.UNIT_END + 0x17C,
        PLAYER_QUEST_LOG_18_1 = UnitField.UNIT_END + 0x180,
        PLAYER_QUEST_LOG_18_2 = UnitField.UNIT_END + 0x184,
        PLAYER_QUEST_LOG_18_3 = UnitField.UNIT_END + 0x188,
        PLAYER_QUEST_LOG_18_5 = UnitField.UNIT_END + 0x190,
        PLAYER_QUEST_LOG_19_1 = UnitField.UNIT_END + 0x194,
        PLAYER_QUEST_LOG_19_2 = UnitField.UNIT_END + 0x198,
        PLAYER_QUEST_LOG_19_3 = UnitField.UNIT_END + 0x19C,
        PLAYER_QUEST_LOG_19_5 = UnitField.UNIT_END + 0x1A4,
        PLAYER_QUEST_LOG_20_1 = UnitField.UNIT_END + 0x1A8,
        PLAYER_QUEST_LOG_20_2 = UnitField.UNIT_END + 0x1AC,
        PLAYER_QUEST_LOG_20_3 = UnitField.UNIT_END + 0x1B0,
        PLAYER_QUEST_LOG_20_5 = UnitField.UNIT_END + 0x1B8,
        PLAYER_QUEST_LOG_21_1 = UnitField.UNIT_END + 0x1BC,
        PLAYER_QUEST_LOG_21_2 = UnitField.UNIT_END + 0x1C0,
        PLAYER_QUEST_LOG_21_3 = UnitField.UNIT_END + 0x1C4,
        PLAYER_QUEST_LOG_21_5 = UnitField.UNIT_END + 0x1CC,
        PLAYER_QUEST_LOG_22_1 = UnitField.UNIT_END + 0x1D0,
        PLAYER_QUEST_LOG_22_2 = UnitField.UNIT_END + 0x1D4,
        PLAYER_QUEST_LOG_22_3 = UnitField.UNIT_END + 0x1D8,
        PLAYER_QUEST_LOG_22_5 = UnitField.UNIT_END + 0x1E0,
        PLAYER_QUEST_LOG_23_1 = UnitField.UNIT_END + 0x1E4,
        PLAYER_QUEST_LOG_23_2 = UnitField.UNIT_END + 0x1E8,
        PLAYER_QUEST_LOG_23_3 = UnitField.UNIT_END + 0x1EC,
        PLAYER_QUEST_LOG_23_5 = UnitField.UNIT_END + 0x1F4,
        PLAYER_QUEST_LOG_24_1 = UnitField.UNIT_END + 0x1F8,
        PLAYER_QUEST_LOG_24_2 = UnitField.UNIT_END + 0x1FC,
        PLAYER_QUEST_LOG_24_3 = UnitField.UNIT_END + 0x200,
        PLAYER_QUEST_LOG_24_5 = UnitField.UNIT_END + 0x208,
        PLAYER_QUEST_LOG_25_1 = UnitField.UNIT_END + 0x20C,
        PLAYER_QUEST_LOG_25_2 = UnitField.UNIT_END + 0x210,
        PLAYER_QUEST_LOG_25_3 = UnitField.UNIT_END + 0x214,
        PLAYER_QUEST_LOG_25_5 = UnitField.UNIT_END + 0x21C,
        PLAYER_QUEST_LOG_26_1 = UnitField.UNIT_END + 0x220,
        PLAYER_QUEST_LOG_26_2 = UnitField.UNIT_END + 0x224,
        PLAYER_QUEST_LOG_26_3 = UnitField.UNIT_END + 0x228,
        PLAYER_QUEST_LOG_26_5 = UnitField.UNIT_END + 0x230,
        PLAYER_QUEST_LOG_27_1 = UnitField.UNIT_END + 0x234,
        PLAYER_QUEST_LOG_27_2 = UnitField.UNIT_END + 0x238,
        PLAYER_QUEST_LOG_27_3 = UnitField.UNIT_END + 0x23C,
        PLAYER_QUEST_LOG_27_5 = UnitField.UNIT_END + 0x244,
        PLAYER_QUEST_LOG_28_1 = UnitField.UNIT_END + 0x248,
        PLAYER_QUEST_LOG_28_2 = UnitField.UNIT_END + 0x24C,
        PLAYER_QUEST_LOG_28_3 = UnitField.UNIT_END + 0x250,
        PLAYER_QUEST_LOG_28_5 = UnitField.UNIT_END + 0x258,
        PLAYER_QUEST_LOG_29_1 = UnitField.UNIT_END + 0x25C,
        PLAYER_QUEST_LOG_29_2 = UnitField.UNIT_END + 0x260,
        PLAYER_QUEST_LOG_29_3 = UnitField.UNIT_END + 0x264,
        PLAYER_QUEST_LOG_29_5 = UnitField.UNIT_END + 0x26C,
        PLAYER_QUEST_LOG_30_1 = UnitField.UNIT_END + 0x270,
        PLAYER_QUEST_LOG_30_2 = UnitField.UNIT_END + 0x274,
        PLAYER_QUEST_LOG_30_3 = UnitField.UNIT_END + 0x278,
        PLAYER_QUEST_LOG_30_5 = UnitField.UNIT_END + 0x280,
        PLAYER_QUEST_LOG_31_1 = UnitField.UNIT_END + 0x284,
        PLAYER_QUEST_LOG_31_2 = UnitField.UNIT_END + 0x288,
        PLAYER_QUEST_LOG_31_3 = UnitField.UNIT_END + 0x28C,
        PLAYER_QUEST_LOG_31_5 = UnitField.UNIT_END + 0x294,
        PLAYER_QUEST_LOG_32_1 = UnitField.UNIT_END + 0x298,
        PLAYER_QUEST_LOG_32_2 = UnitField.UNIT_END + 0x29C,
        PLAYER_QUEST_LOG_32_3 = UnitField.UNIT_END + 0x2A0,
        PLAYER_QUEST_LOG_32_5 = UnitField.UNIT_END + 0x2A8,
        PLAYER_QUEST_LOG_33_1 = UnitField.UNIT_END + 0x2AC,
        PLAYER_QUEST_LOG_33_2 = UnitField.UNIT_END + 0x2B0,
        PLAYER_QUEST_LOG_33_3 = UnitField.UNIT_END + 0x2B4,
        PLAYER_QUEST_LOG_33_5 = UnitField.UNIT_END + 0x2BC,
        PLAYER_QUEST_LOG_34_1 = UnitField.UNIT_END + 0x2C0,
        PLAYER_QUEST_LOG_34_2 = UnitField.UNIT_END + 0x2C4,
        PLAYER_QUEST_LOG_34_3 = UnitField.UNIT_END + 0x2C8,
        PLAYER_QUEST_LOG_34_5 = UnitField.UNIT_END + 0x2D0,
        PLAYER_QUEST_LOG_35_1 = UnitField.UNIT_END + 0x2D4,
        PLAYER_QUEST_LOG_35_2 = UnitField.UNIT_END + 0x2D8,
        PLAYER_QUEST_LOG_35_3 = UnitField.UNIT_END + 0x2DC,
        PLAYER_QUEST_LOG_35_5 = UnitField.UNIT_END + 0x2E4,
        PLAYER_QUEST_LOG_36_1 = UnitField.UNIT_END + 0x2E8,
        PLAYER_QUEST_LOG_36_2 = UnitField.UNIT_END + 0x2EC,
        PLAYER_QUEST_LOG_36_3 = UnitField.UNIT_END + 0x2F0,
        PLAYER_QUEST_LOG_36_5 = UnitField.UNIT_END + 0x2F8,
        PLAYER_QUEST_LOG_37_1 = UnitField.UNIT_END + 0x2FC,
        PLAYER_QUEST_LOG_37_2 = UnitField.UNIT_END + 0x300,
        PLAYER_QUEST_LOG_37_3 = UnitField.UNIT_END + 0x304,
        PLAYER_QUEST_LOG_37_5 = UnitField.UNIT_END + 0x30C,
        PLAYER_QUEST_LOG_38_1 = UnitField.UNIT_END + 0x310,
        PLAYER_QUEST_LOG_38_2 = UnitField.UNIT_END + 0x314,
        PLAYER_QUEST_LOG_38_3 = UnitField.UNIT_END + 0x318,
        PLAYER_QUEST_LOG_38_5 = UnitField.UNIT_END + 0x320,
        PLAYER_QUEST_LOG_39_1 = UnitField.UNIT_END + 0x324,
        PLAYER_QUEST_LOG_39_2 = UnitField.UNIT_END + 0x328,
        PLAYER_QUEST_LOG_39_3 = UnitField.UNIT_END + 0x32C,
        PLAYER_QUEST_LOG_39_5 = UnitField.UNIT_END + 0x334,
        PLAYER_QUEST_LOG_40_1 = UnitField.UNIT_END + 0x338,
        PLAYER_QUEST_LOG_40_2 = UnitField.UNIT_END + 0x33C,
        PLAYER_QUEST_LOG_40_3 = UnitField.UNIT_END + 0x340,
        PLAYER_QUEST_LOG_40_5 = UnitField.UNIT_END + 0x348,
        PLAYER_QUEST_LOG_41_1 = UnitField.UNIT_END + 0x34C,
        PLAYER_QUEST_LOG_41_2 = UnitField.UNIT_END + 0x350,
        PLAYER_QUEST_LOG_41_3 = UnitField.UNIT_END + 0x354,
        PLAYER_QUEST_LOG_41_5 = UnitField.UNIT_END + 0x35C,
        PLAYER_QUEST_LOG_42_1 = UnitField.UNIT_END + 0x360,
        PLAYER_QUEST_LOG_42_2 = UnitField.UNIT_END + 0x364,
        PLAYER_QUEST_LOG_42_3 = UnitField.UNIT_END + 0x368,
        PLAYER_QUEST_LOG_42_5 = UnitField.UNIT_END + 0x370,
        PLAYER_QUEST_LOG_43_1 = UnitField.UNIT_END + 0x374,
        PLAYER_QUEST_LOG_43_2 = UnitField.UNIT_END + 0x378,
        PLAYER_QUEST_LOG_43_3 = UnitField.UNIT_END + 0x37C,
        PLAYER_QUEST_LOG_43_5 = UnitField.UNIT_END + 0x384,
        PLAYER_QUEST_LOG_44_1 = UnitField.UNIT_END + 0x388,
        PLAYER_QUEST_LOG_44_2 = UnitField.UNIT_END + 0x38C,
        PLAYER_QUEST_LOG_44_3 = UnitField.UNIT_END + 0x390,
        PLAYER_QUEST_LOG_44_5 = UnitField.UNIT_END + 0x398,
        PLAYER_QUEST_LOG_45_1 = UnitField.UNIT_END + 0x39C,
        PLAYER_QUEST_LOG_45_2 = UnitField.UNIT_END + 0x3A0,
        PLAYER_QUEST_LOG_45_3 = UnitField.UNIT_END + 0x3A4,
        PLAYER_QUEST_LOG_45_5 = UnitField.UNIT_END + 0x3AC,
        PLAYER_QUEST_LOG_46_1 = UnitField.UNIT_END + 0x3B0,
        PLAYER_QUEST_LOG_46_2 = UnitField.UNIT_END + 0x3B4,
        PLAYER_QUEST_LOG_46_3 = UnitField.UNIT_END + 0x3B8,
        PLAYER_QUEST_LOG_46_5 = UnitField.UNIT_END + 0x3C0,
        PLAYER_QUEST_LOG_47_1 = UnitField.UNIT_END + 0x3C4,
        PLAYER_QUEST_LOG_47_2 = UnitField.UNIT_END + 0x3C8,
        PLAYER_QUEST_LOG_47_3 = UnitField.UNIT_END + 0x3CC,
        PLAYER_QUEST_LOG_47_5 = UnitField.UNIT_END + 0x3D4,
        PLAYER_QUEST_LOG_48_1 = UnitField.UNIT_END + 0x3D8,
        PLAYER_QUEST_LOG_48_2 = UnitField.UNIT_END + 0x3DC,
        PLAYER_QUEST_LOG_48_3 = UnitField.UNIT_END + 0x3E0,
        PLAYER_QUEST_LOG_48_5 = UnitField.UNIT_END + 0x3E8,
        PLAYER_QUEST_LOG_49_1 = UnitField.UNIT_END + 0x3EC,
        PLAYER_QUEST_LOG_49_2 = UnitField.UNIT_END + 0x3F0,
        PLAYER_QUEST_LOG_49_3 = UnitField.UNIT_END + 0x3F4,
        PLAYER_QUEST_LOG_49_5 = UnitField.UNIT_END + 0x3FC,
        PLAYER_QUEST_LOG_50_1 = UnitField.UNIT_END + 0x400,
        PLAYER_QUEST_LOG_50_2 = UnitField.UNIT_END + 0x404,
        PLAYER_QUEST_LOG_50_3 = UnitField.UNIT_END + 0x408,
        PLAYER_QUEST_LOG_50_5 = UnitField.UNIT_END + 0x410,
        PLAYER_VISIBLE_ITEM_1_ENTRYID = UnitField.UNIT_END + 0x414,
        PLAYER_VISIBLE_ITEM_1_ENCHANTMENT = UnitField.UNIT_END + 0x418,
        PLAYER_VISIBLE_ITEM_2_ENTRYID = UnitField.UNIT_END + 0x41C,
        PLAYER_VISIBLE_ITEM_2_ENCHANTMENT = UnitField.UNIT_END + 0x420,
        PLAYER_VISIBLE_ITEM_3_ENTRYID = UnitField.UNIT_END + 0x424,
        PLAYER_VISIBLE_ITEM_3_ENCHANTMENT = UnitField.UNIT_END + 0x428,
        PLAYER_VISIBLE_ITEM_4_ENTRYID = UnitField.UNIT_END + 0x42C,
        PLAYER_VISIBLE_ITEM_4_ENCHANTMENT = UnitField.UNIT_END + 0x430,
        PLAYER_VISIBLE_ITEM_5_ENTRYID = UnitField.UNIT_END + 0x434,
        PLAYER_VISIBLE_ITEM_5_ENCHANTMENT = UnitField.UNIT_END + 0x438,
        PLAYER_VISIBLE_ITEM_6_ENTRYID = UnitField.UNIT_END + 0x43C,
        PLAYER_VISIBLE_ITEM_6_ENCHANTMENT = UnitField.UNIT_END + 0x440,
        PLAYER_VISIBLE_ITEM_7_ENTRYID = UnitField.UNIT_END + 0x444,
        PLAYER_VISIBLE_ITEM_7_ENCHANTMENT = UnitField.UNIT_END + 0x448,
        PLAYER_VISIBLE_ITEM_8_ENTRYID = UnitField.UNIT_END + 0x44C,
        PLAYER_VISIBLE_ITEM_8_ENCHANTMENT = UnitField.UNIT_END + 0x450,
        PLAYER_VISIBLE_ITEM_9_ENTRYID = UnitField.UNIT_END + 0x454,
        PLAYER_VISIBLE_ITEM_9_ENCHANTMENT = UnitField.UNIT_END + 0x458,
        PLAYER_VISIBLE_ITEM_10_ENTRYID = UnitField.UNIT_END + 0x45C,
        PLAYER_VISIBLE_ITEM_10_ENCHANTMENT = UnitField.UNIT_END + 0x460,
        PLAYER_VISIBLE_ITEM_11_ENTRYID = UnitField.UNIT_END + 0x464,
        PLAYER_VISIBLE_ITEM_11_ENCHANTMENT = UnitField.UNIT_END + 0x468,
        PLAYER_VISIBLE_ITEM_12_ENTRYID = UnitField.UNIT_END + 0x46C,
        PLAYER_VISIBLE_ITEM_12_ENCHANTMENT = UnitField.UNIT_END + 0x470,
        PLAYER_VISIBLE_ITEM_13_ENTRYID = UnitField.UNIT_END + 0x474,
        PLAYER_VISIBLE_ITEM_13_ENCHANTMENT = UnitField.UNIT_END + 0x478,
        PLAYER_VISIBLE_ITEM_14_ENTRYID = UnitField.UNIT_END + 0x47C,
        PLAYER_VISIBLE_ITEM_14_ENCHANTMENT = UnitField.UNIT_END + 0x480,
        PLAYER_VISIBLE_ITEM_15_ENTRYID = UnitField.UNIT_END + 0x484,
        PLAYER_VISIBLE_ITEM_15_ENCHANTMENT = UnitField.UNIT_END + 0x488,
        PLAYER_VISIBLE_ITEM_16_ENTRYID = UnitField.UNIT_END + 0x48C,
        PLAYER_VISIBLE_ITEM_16_ENCHANTMENT = UnitField.UNIT_END + 0x490,
        PLAYER_VISIBLE_ITEM_17_ENTRYID = UnitField.UNIT_END + 0x494,
        PLAYER_VISIBLE_ITEM_17_ENCHANTMENT = UnitField.UNIT_END + 0x498,
        PLAYER_VISIBLE_ITEM_18_ENTRYID = UnitField.UNIT_END + 0x49C,
        PLAYER_VISIBLE_ITEM_18_ENCHANTMENT = UnitField.UNIT_END + 0x4A0,
        PLAYER_VISIBLE_ITEM_19_ENTRYID = UnitField.UNIT_END + 0x4A4,
        PLAYER_VISIBLE_ITEM_19_ENCHANTMENT = UnitField.UNIT_END + 0x4A8,
        PLAYER_CHOSEN_TITLE = UnitField.UNIT_END + 0x4AC,
        PLAYER_FAKE_INEBRIATION = UnitField.UNIT_END + 0x4B0,
        PLAYER_FIELD_PAD_0 = UnitField.UNIT_END + 0x4B4,
        PLAYER_FIELD_INV_SLOT_HEAD = UnitField.UNIT_END + 0x4B8,
        PLAYER_FIELD_PACK_SLOT_1 = UnitField.UNIT_END + 0x570,
        PLAYER_FIELD_BANK_SLOT_1 = UnitField.UNIT_END + 0x5F0,
        PLAYER_FIELD_BANKBAG_SLOT_1 = UnitField.UNIT_END + 0x6D0,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_1 = UnitField.UNIT_END + 0x708,
        PLAYER_FIELD_KEYRING_SLOT_1 = UnitField.UNIT_END + 0x768,
        PLAYER_FARSIGHT = UnitField.UNIT_END + 0x868,
        PLAYER__FIELD_KNOWN_TITLES = UnitField.UNIT_END + 0x870,
        PLAYER__FIELD_KNOWN_TITLES1 = UnitField.UNIT_END + 0x878,
        PLAYER__FIELD_KNOWN_TITLES2 = UnitField.UNIT_END + 0x880,
        PLAYER_XP = UnitField.UNIT_END + 0x888,
        PLAYER_NEXT_LEVEL_XP = UnitField.UNIT_END + 0x88C,
        PLAYER_SKILL_INFO_1_1 = UnitField.UNIT_END + 0x890,
        PLAYER_CHARACTER_POINTS = UnitField.UNIT_END + 0xE90,
        PLAYER_TRACK_CREATURES = UnitField.UNIT_END + 0xE94,
        PLAYER_TRACK_RESOURCES = UnitField.UNIT_END + 0xE98,
        PLAYER_BLOCK_PERCENTAGE = UnitField.UNIT_END + 0xE9C,
        PLAYER_DODGE_PERCENTAGE = UnitField.UNIT_END + 0xEA0,
        PLAYER_PARRY_PERCENTAGE = UnitField.UNIT_END + 0xEA4,
        PLAYER_EXPERTISE = UnitField.UNIT_END + 0xEA8,
        PLAYER_OFFHAND_EXPERTISE = UnitField.UNIT_END + 0xEAC,
        PLAYER_CRIT_PERCENTAGE = UnitField.UNIT_END + 0xEB0,
        PLAYER_RANGED_CRIT_PERCENTAGE = UnitField.UNIT_END + 0xEB4,
        PLAYER_OFFHAND_CRIT_PERCENTAGE = UnitField.UNIT_END + 0xEB8,
        PLAYER_SPELL_CRIT_PERCENTAGE1 = UnitField.UNIT_END + 0xEBC,
        PLAYER_SHIELD_BLOCK = UnitField.UNIT_END + 0xED8,
        PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE = UnitField.UNIT_END + 0xEDC,
        PLAYER_MASTERY = UnitField.UNIT_END + 0xEE0,
        PLAYER_EXPLORED_ZONES_1 = UnitField.UNIT_END + 0xEE4,
        PLAYER_REST_STATE_EXPERIENCE = UnitField.UNIT_END + 0x1124,
        PLAYER_FIELD_COINAGE = UnitField.UNIT_END + 0x1128,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS = UnitField.UNIT_END + 0x1130,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = UnitField.UNIT_END + 0x114C,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = UnitField.UNIT_END + 0x1168,
        PLAYER_FIELD_MOD_HEALING_DONE_POS = UnitField.UNIT_END + 0x1184,
        PLAYER_FIELD_MOD_HEALING_PCT = UnitField.UNIT_END + 0x1188,
        PLAYER_FIELD_MOD_HEALING_DONE_PCT = UnitField.UNIT_END + 0x118C,
        PLAYER_FIELD_MOD_SPELL_POWER_PCT = UnitField.UNIT_END + 0x1190,
        PLAYER_FIELD_MOD_TARGET_RESISTANCE = UnitField.UNIT_END + 0x1194,
        PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE = UnitField.UNIT_END + 0x1198,
        PLAYER_FIELD_BYTES = UnitField.UNIT_END + 0x119C,
        PLAYER_SELF_RES_SPELL = UnitField.UNIT_END + 0x11A0,
        PLAYER_FIELD_PVP_MEDALS = UnitField.UNIT_END + 0x11A4,
        PLAYER_FIELD_BUYBACK_PRICE_1 = UnitField.UNIT_END + 0x11A8,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_1 = UnitField.UNIT_END + 0x11D8,
        PLAYER_FIELD_KILLS = UnitField.UNIT_END + 0x1208,
        PLAYER_FIELD_LIFETIME_HONORBALE_KILLS = UnitField.UNIT_END + 0x120C,
        PLAYER_FIELD_BYTES2 = UnitField.UNIT_END + 0x1210,
        PLAYER_FIELD_WATCHED_FACTION_INDEX = UnitField.UNIT_END + 0x1214,
        PLAYER_FIELD_COMBAT_RATING_1 = UnitField.UNIT_END + 0x1218,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_1 = UnitField.UNIT_END + 0x1280,
        PLAYER_FIELD_BATTLEGROUND_RATING = UnitField.UNIT_END + 0x12D4,
        PLAYER_FIELD_MAX_LEVEL = UnitField.UNIT_END + 0x12D8,
        PLAYER_FIELD_DAILY_QUESTS_1 = UnitField.UNIT_END + 0x12DC,
        PLAYER_RUNE_REGEN_1 = UnitField.UNIT_END + 0x1340,
        PLAYER_NO_REAGENT_COST_1 = UnitField.UNIT_END + 0x1350,
        PLAYER_FIELD_GLYPH_SLOTS_1 = UnitField.UNIT_END + 0x135C,
        PLAYER_FIELD_GLYPHS_1 = UnitField.UNIT_END + 0x1380,
        PLAYER_GLYPHS_ENABLED = UnitField.UNIT_END + 0x13A4,
        PLAYER_PET_SPELL_POWER = UnitField.UNIT_END + 0x13A8,
        PLAYER_FIELD_RESEARCHING_1 = UnitField.UNIT_END + 0x13AC,
        PLAYER_FIELD_RESERACH_SITE_1 = UnitField.UNIT_END + 0x13CC,
        PLAYER_PROFESSION_SKILL_LINE_1 = UnitField.UNIT_END + 0x13EC,
        PLAYER_FIELD_UI_HIT_MODIFIER = UnitField.UNIT_END + 0x13F4,
        PLAYER_FIELD_UI_SPELL_HIT_MODIFIER = UnitField.UNIT_END + 0x13F8,
        PLAYER_FIELD_HOME_REALM_TIME_OFFSET = UnitField.UNIT_END + 0x13FC,
        PLAYER_END = UnitField.UNIT_END + 0x1400
    }

    // Descriptors: 0x00C14890
    public enum ContainerField : uint
    {
        CONTAINER_FIELD_NUM_SLOTS = ItemField.ITEM_END + 0x0,
        CONTAINER_ALIGN_PAD = ItemField.ITEM_END + 0x4,
        CONTAINER_FIELD_SLOT_1 = ItemField.ITEM_END + 0x8,
        CONTAINER_END = ItemField.ITEM_END + 0x128
    }

    // Descriptors: 0x00C16958
    public enum GameObjectField : uint
    {
        GAMEOBJECT_DISPLAYID = ObjectField.OBJECT_END + 0x8,
        GAMEOBJECT_FLAGS = ObjectField.OBJECT_END + 0xC,
        GAMEOBJECT_PARENTROTATION = ObjectField.OBJECT_END + 0x10,
        GAMEOBJECT_DYNAMIC = ObjectField.OBJECT_END + 0x20,
        GAMEOBJECT_FACTION = ObjectField.OBJECT_END + 0x24,
        GAMEOBJECT_LEVEL = ObjectField.OBJECT_END + 0x28,
        GAMEOBJECT_BYTES_1 = ObjectField.OBJECT_END + 0x2C,
        GAMEOBJECT_END = ObjectField.OBJECT_END + 0x30
    }

    // Descriptors: 0x00C169F8
    public enum DynamicObjectField : uint
    {
        DYNAMICOBJECT_CASTER = ObjectField.OBJECT_END + 0x0,
        DYNAMICOBJECT_BYTES = ObjectField.OBJECT_END + 0x8,
        DYNAMICOBJECT_SPELLID = ObjectField.OBJECT_END + 0xC,
        DYNAMICOBJECT_RADIUS = ObjectField.OBJECT_END + 0x10,
        DYNAMICOBJECT_CASTTIME = ObjectField.OBJECT_END + 0x14,
        DYNAMICOBJECT_END = ObjectField.OBJECT_END + 0x18
    }

    // Descriptors: 0x00C16A60
    public enum CorpseField : uint
    {
        CORPSE_FIELD_OWNER = ObjectField.OBJECT_END + 0x0,
        CORPSE_FIELD_PARTY = ObjectField.OBJECT_END + 0x8,
        CORPSE_FIELD_DISPLAY_ID = ObjectField.OBJECT_END + 0x10,
        CORPSE_FIELD_ITEM = ObjectField.OBJECT_END + 0x14,
        CORPSE_FIELD_BYTES_1 = ObjectField.OBJECT_END + 0x60,
        CORPSE_FIELD_BYTES_2 = ObjectField.OBJECT_END + 0x64,
        CORPSE_FIELD_FLAGS = ObjectField.OBJECT_END + 0x68,
        CORPSE_FIELD_DYNAMIC_FLAGS = ObjectField.OBJECT_END + 0x6C,
        CORPSE_END = ObjectField.OBJECT_END + 0x70
    }


}
