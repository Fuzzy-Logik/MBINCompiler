﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC5B5E7E09FF7A701)]
    public class GcStatType : GameComponentType {

		public enum StatTypeEnum { Int, Float, AvgRate }
		public StatTypeEnum StatType;
    }
}
