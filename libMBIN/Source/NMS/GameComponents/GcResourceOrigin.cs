﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x64987573D6129EB5)]
    public class GcResourceOrigin : GameComponent {

		public enum ResourceOriginEnum { Terrain, Crystal, Asteroid, Robot, Depot }
		public ResourceOriginEnum ResourceOrigin;
    }
}
