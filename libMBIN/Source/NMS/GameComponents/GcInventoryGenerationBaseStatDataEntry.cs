﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4A53B69223F74C8F)]
    public class GcInventoryGenerationBaseStatDataEntry : GameComponentType {

        [NMS(Size = 0x10)]
        /* 0x00 */ public string BaseStatID;
        /* 0x10 */ public float Min;
        /* 0x14 */ public float Max;
        /* 0x18 */ public float MinFixedAdd;
        /* 0x1C */ public float MaxFixedAdd;
    }
}
