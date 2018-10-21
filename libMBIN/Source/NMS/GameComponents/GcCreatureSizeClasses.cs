﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7ED9817F76276B01)]
    public class GcCreatureSizeClasses : GameComponent {

		public enum CreatureSizeClassEnum { Small, Medium, Large, Huge }
		public CreatureSizeClassEnum CreatureSizeClass;
    }
}
