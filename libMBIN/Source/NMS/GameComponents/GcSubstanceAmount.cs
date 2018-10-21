﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x15E8BBC4FDB928FE)]
    public class GcSubstanceAmount : GameComponentType {

        public int AmountMin;
        public int AmountMax;
        [NMS(Size = 0x10)]
        public string Specific;
        [NMS(Size = 0x10)]
        public string SpecificSecondary;

        public GcRealitySubstanceCategory SubstanceCategory;
        public GcRarity Rarity;
    }
}
