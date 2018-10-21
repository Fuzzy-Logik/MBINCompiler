﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDF3A7624A71B6C10)]
    public class GcMissionSequenceGetUnitsToBuyItem : GameComponent {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Item;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
