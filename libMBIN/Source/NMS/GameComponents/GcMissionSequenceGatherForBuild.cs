﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF63AD61FDA9AB477)]
    public class GcMissionSequenceGatherForBuild : GameComponent {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string TargetTech;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string GatherResource;
        [NMS(Size = 0x80)]
        /* 0x0A0 */ public string DebugText;
    }
}
