﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x30093440ED31F004)]
    public class GcGalaxyStarTypes : GameComponentType {

		public enum GalaxyStarTypeEnum { Yellow, Green, Blue, Red }
		public GalaxyStarTypeEnum GalaxyStarType;
    }
}
