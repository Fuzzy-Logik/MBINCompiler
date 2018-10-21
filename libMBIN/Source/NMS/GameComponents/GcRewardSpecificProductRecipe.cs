﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF76E52C52365A783)]
    public class GcRewardSpecificProductRecipe : GameComponentType {

        [NMS(Size = 0x10)]
        public string Id;
        public bool Slient;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
