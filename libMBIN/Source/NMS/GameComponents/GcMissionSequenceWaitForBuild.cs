﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x67831DB54A6008E8)]
    public class GcMissionSequenceWaitForBuild : GameComponent {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string TargetTech;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
