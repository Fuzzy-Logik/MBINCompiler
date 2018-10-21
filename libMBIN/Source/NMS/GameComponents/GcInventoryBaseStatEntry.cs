﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC377F0E807316984)]
    public class GcInventoryBaseStatEntry : GameComponentType {

        [NMS(Size = 0x10)]
        public string BaseStatID;
        public float Value;
    }
}
