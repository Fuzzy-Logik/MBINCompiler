﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x827AF33FF68FE05F)]
    public class GcCostProduct : GameComponentType {

        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;

        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;
        /* 0x18 */ public int Amount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
