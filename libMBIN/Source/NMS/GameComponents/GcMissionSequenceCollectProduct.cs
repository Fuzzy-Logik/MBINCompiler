﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x140, GUID = 0x16C5A62836C2DE78)]
    public class GcMissionSequenceCollectProduct : GameComponentType {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcDefaultMissionProductEnum Default;
        /* 0x084 */ public GcProductTableEnum Product;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        /* 0x090 */ public bool WaitForSelected;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x091 */ public byte[] Padding91;
        [NMS(Size = 0x10)]
        /* 0x098 */ public string ForBuild;
        [NMS(Size = 0x10)]
        /* 0x0A8 */ public string ForRepair;
        /* 0x0B8 */ public bool TeachIfNotKnown;
        [NMS(Size = 0x80)]
        /* 0x0B9 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x139 */ public byte[] EndPadding;
    }
}
