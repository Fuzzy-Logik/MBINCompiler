﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x988A28699F489DCB)]
    public class GcCostInstalledTech : GameComponentType {

        [NMS(Size = 0x10)]
        public string Id;
		
        public int InvetoryToCheck;
		public enum InventoryToCheckEnum { All, Suit, Ship, Weapon, Freighter, Buggy }
		public InventoryToCheckEnum InventoryToCheck;
    }
}
