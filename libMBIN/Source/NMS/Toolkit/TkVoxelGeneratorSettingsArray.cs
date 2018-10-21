﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1B440, GUID = 0xC4741AF54DADAC92)]
    public class TkVoxelGeneratorSettingsArray : ToolkitData {

        [NMS(Size = 0xA, EnumValue = new[] { "FloatingIslands", "GrandCanyon", "MountainRavines", "HugeArches", "Alien", "Craters", "Caverns", "Alpine", "LilyPad", "Desert" })]        // TkVoxelGeneratorSettingsTypes
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
