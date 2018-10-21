﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x64BEA061A645390)]
    public class GcRewardSpecificProductRecipeFromList : GameComponent {

        public List<NMSString0x10> ProductList;

		public enum ProductListRewardOrderEnum { OneRandom, InOrder, TryAllRandom }
		public ProductListRewardOrderEnum ProductListRewardOrder;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
