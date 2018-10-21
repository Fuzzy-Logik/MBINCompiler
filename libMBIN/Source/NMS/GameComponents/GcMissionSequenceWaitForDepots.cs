﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5983B88C47522ECD)]
    public class GcMissionSequenceWaitForDepots : GameComponentType {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int AmountMin;
        /* 0x084 */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x088 */ public string DebugText;
    }
}
