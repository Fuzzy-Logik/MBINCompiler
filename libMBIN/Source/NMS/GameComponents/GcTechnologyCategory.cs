﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3797D16E9397A243)]
    public class GcTechnologyCategory : GameComponentType {

		public enum TechnologyCategoryEnum { Ship, Weapon, Suit, Personal, All, None, Freighter, Vehicle, Maintenance }
		public TechnologyCategoryEnum TechnologyCategory;
    }
}
