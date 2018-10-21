﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD930090CE3C00E66)]
    public class GcGalaxyStarAnomaly : GameComponent {

		public enum GalaxyStarAnomalyEnum { None, AtlasStation, AtlasStationFinal, BlackHole, MiniStation }
		public GalaxyStarAnomalyEnum GalaxyStarAnomaly;
    }
}
