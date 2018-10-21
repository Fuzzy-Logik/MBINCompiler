﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE06E78532B6DAA85)]
    public class GcMissionSequenceWaitForShips : GameComponentType {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcRealityCommonFactions Type;
        /* 0x084 */ public int Count;
        [NMS(Size = 0x80)]
        /* 0x088 */ public string DebugText;
    }
}
