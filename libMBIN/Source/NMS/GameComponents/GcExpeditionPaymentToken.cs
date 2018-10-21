﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9724C1F33A4A3060)]
    public class GcExpeditionPaymentToken : GameComponentType {

        [NMS(Size = 0x10)]
        public string TokenName;
        public int TokenValue;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
