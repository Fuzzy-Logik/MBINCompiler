﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8260892F03FDBFC0)]
    public class GcMissionConsequenceRemoveScanEvent : GameComponent {

        [NMS(Size = 0x20)]
        /* 0x00 */ public string Event;
    }
}
