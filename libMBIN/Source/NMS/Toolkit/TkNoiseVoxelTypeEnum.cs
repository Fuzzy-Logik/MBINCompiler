﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x68CC5C66BE9C1E10)]
    public class TkNoiseVoxelTypeEnum : ToolkitData {

		public enum NoiseVoxelTypeEnum { Base, Rock, Mountain, Sand, Cave, Substance_1, Substance_2, Substance_3, RandomRock, RandomRockOrSubstance }
		public NoiseVoxelTypeEnum NoiseVoxelType;
    }
}
