﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x872B03D69317AF30)]
    public class GcCameraAmbientSpaceData : GameComponent {

        [NMS(Size = 0x10)]
        /* 0x00 */ public string Animation;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DroneAnimation;
		public enum OriginEnum { SpaceStationInternals, SpaceStationBack, FreighterBattle, Freighter, FreighterHangar, AtlasStation, BlackHole, Anomaly }
		public OriginEnum Origin;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
