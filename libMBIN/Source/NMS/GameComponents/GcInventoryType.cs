﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5C2AD9EDC86BBE93)]
    public class GcInventoryType : GameComponent {

		public enum InventoryTypeEnum { Substance, Technology, Product }
		public InventoryTypeEnum InventoryType;
    }
}
