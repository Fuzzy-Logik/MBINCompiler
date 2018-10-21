﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6EA695AFABAD730F)]
    public class GcTradingCategoryData : GameComponentType {

        [NMS(Size = 0x40)]
        /* 0x00 */ public string Name;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public float ProductMultiplierChangePer100;
        /* 0xC8 */ public float SubstanceMultiplierChangePer100;
    }
}
