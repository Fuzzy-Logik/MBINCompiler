﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1A248F0F98435D2F)]
    public class GcMissionGalacticPoint : GameComponent {

		public enum GalacticPointEnum { Atlas, BlackHole }
		public GalacticPointEnum GalacticPoint;
    }
}
