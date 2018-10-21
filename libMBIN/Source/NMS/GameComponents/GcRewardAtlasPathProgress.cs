﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x40F3E6BA599AC188)]
    public class GcRewardAtlasPathProgress : GameComponentType {

		public enum AtlasPathProgressTypeEnum { IncrementPathProgress, FinalStoryAtlas }
		public AtlasPathProgressTypeEnum AtlasPathProgressType;
    }
}
