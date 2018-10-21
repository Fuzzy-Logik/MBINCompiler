﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6BA9CBE0ED534658)]
    public class GcMissionConditionBasePartNear : GameComponent {

        [NMS(Size = 0x10)]
        /* 0x00 */ public string PartID;
        /* 0x10 */ public float Distance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] EndPadding;
    }
}
