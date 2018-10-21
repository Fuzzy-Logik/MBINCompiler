﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4CE334B92351578B)]
    public class GcItemCostData : GameComponentType {

        [NMS(Size = 0x10)]
        public string ID;
        public float Cost;
        public float MinCost;
        public float MaxCost;
        public float ChangePerSale;
    }
}
