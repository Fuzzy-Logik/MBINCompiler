﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x360F73387712D16B)]
    public class GcSubstanceSecondary : GameComponent {

        [NMS(Size = 0x10)]
        public string ID;
        public float Chance;
        public float AmountMin;
        public float AmountMax;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
