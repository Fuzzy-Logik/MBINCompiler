﻿namespace libMBIN.Models.Structs
{
    public class GcInventoryTableEntry : NMSTemplate        // size: 0x20
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public int MinSize;
        /* 0x14 */ public int MaxSize;
        /* 0x18 */ public GcInventoryLayoutSizeType LayoutSizeType;
        [NMS(Size = 4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
