﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x7CCDABAB01548488)]
    public class GcPortalData : GameComponentType {

        /* 0x0 */ public float RuneRotateTime;      // 3F000000h
        /* 0x4 */ public bool SkipRuneEntry;        // 1
        /* 0x5 */ public bool KnowAllRunes;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x6 */ public byte[] EndPadding;
    }
}
