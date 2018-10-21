﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8AF7F1C3674147C5)]
    public class GcDay : GameComponent {

		public enum DayEnum { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
		public DayEnum Day;
    }
}
