﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBCC12AC4DCFC035C)]
    public class GcTradeCategory : GameComponentType {

		public enum TradingClassEnum { Mineral, Tech, Commodity, Component, Alloy, Exotic, Energy, None }
		public TradingClassEnum TradingClass;
    }
}
