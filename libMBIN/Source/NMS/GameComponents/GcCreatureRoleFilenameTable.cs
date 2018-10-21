﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x130, GUID = 0xC36AF007B149AFB6)]
    public class GcCreatureRoleFilenameTable : GameComponentType {

        [NMS(Size = 0xD, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        /* 0x000 */ public GcCreatureRoleFilenameList[] BiomeFiles;

        /* 0x0D0 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        /* 0x0E0 */ public GcCreatureRoleFilenameList CaveFiles;
        /* 0x0F0 */ public GcCreatureRoleFilenameList AirFiles;
        /* 0x100 */ public GcCreatureRoleFilenameList RobotFiles;

        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        /* 0x110 */ public float[] LifeChance;

        [NMS(Size = 4)]
        /* 0x120 */ public float[] RoleFrequencyModifiers;
    }
}
