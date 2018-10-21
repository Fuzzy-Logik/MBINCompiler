﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7CF47685DC6899D2)]
    public class GcMissionSequenceWaitForWarps : GameComponent {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x08 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
