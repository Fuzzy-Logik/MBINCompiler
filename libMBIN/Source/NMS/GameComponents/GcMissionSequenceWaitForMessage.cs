﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD0F049A601EDA573)]
    public class GcMissionSequenceWaitForMessage : GameComponentType {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string WaitMessageID;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
