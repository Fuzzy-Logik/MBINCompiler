﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBE2FC37325C56C05)]
    public class GcPlanetSentinelData : GameComponent {

		public enum SentinelLevelEnum { Default, Aggressive }
		public SentinelLevelEnum SentinelLevel;

        public int MaxActiveDrones;
    }
}
