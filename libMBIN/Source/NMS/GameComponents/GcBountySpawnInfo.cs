﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x170, GUID = 0x6C46CCF45793F1A4)]
    public class GcBountySpawnInfo : GameComponentType {

        [NMS(Size = 0x10)]
	    /* 0x000 */ public string Id;
        /* 0x010 */ public GcAIShipSpawnData Data;
        [NMS(Size = 0x10)]
        /* 0x0B8 */ public string AttackData;
        /* 0x0C8 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14C */ public byte[] Padding14C;
        [NMS(Size = 0x20)]
        /* 0x150 */ public string Label;
    }
}
