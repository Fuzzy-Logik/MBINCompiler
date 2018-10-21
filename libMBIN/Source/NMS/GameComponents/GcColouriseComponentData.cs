﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCCB13805BC4EFC10)]
    public class GcColouriseComponentData : GameComponent {

        public Colour PrimaryColour;
        public Colour SecondaryColour;
    }
}
