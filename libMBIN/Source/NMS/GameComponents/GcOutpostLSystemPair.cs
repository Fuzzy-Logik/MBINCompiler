﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDBC5A035A3C5D89D)]
    public class GcOutpostLSystemPair : GameComponent {

        [NMS(Size = 0x20)]
        public string Locator;
        [NMS(Size = 7)]
        public NMSString0x80[] LSystems;
    }
}
