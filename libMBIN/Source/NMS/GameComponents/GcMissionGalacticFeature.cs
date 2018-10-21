﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB6EBBD7E6C55765C)]
    public class GcMissionGalacticFeature : GameComponent {

		public enum GalacticFeatureEnum { Anomaly, Atlas, BlackHole }
		public GalacticFeatureEnum GalacticFeature;
    }
}
