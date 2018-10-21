﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x7F4FEC98BB8FF450)]
    public class GcHeavyAirColourData : GameComponentType {

        /* 0x000 */ public Colour Colour1;
        /* 0x010 */ public Colour Colour2;
    }
}
