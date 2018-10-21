﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE38558DF9FE4C519)]
    public class GcBiomeType : GameComponent {

		public enum BiomeEnum { Lush, Toxic, Scorched, Radioactive, Frozen, Barren, Dead, Weird, Red, Green, Blue, Test, All }
		public BiomeEnum Biome;
    }
}
