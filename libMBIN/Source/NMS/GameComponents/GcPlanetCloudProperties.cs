﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xB03EBE7F6DAB192)]
    public class GcPlanetCloudProperties : GameComponentType {

        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public float Coverage1;
        /* 0x14 */ public float Coverage2;
        /* 0x18 */ public float Coverage3;
        /* 0x1C */ public float Offset1;
        /* 0x20 */ public float Offset2;
        /* 0x24 */ public float Offset3;
    }
}
