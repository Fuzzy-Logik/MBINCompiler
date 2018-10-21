﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x488A2F49CCD026FC)]
    public class GcPlayerOwnershipData : GameComponent {

        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcInventoryContainer Inventory;
        /* 0x328 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x388 */ public GcInventoryLayout InventoryLayout;
        /* 0x3A8 */ public ulong Location;
        /* 0x3B0 */ public Vector4f Position;
        /* 0x3C0 */ public Vector4f Direction;
    }
}
