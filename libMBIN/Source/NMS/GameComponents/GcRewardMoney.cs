﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x304763E55680D650)]
    public class GcRewardMoney : GameComponentType {

        public int AmountMin;
        public int AmountMax;
		public enum CurrencyEnum { Units, Nanites, Specials }
		public CurrencyEnum Currency;
    }
}
