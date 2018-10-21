﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF3CA17CA103F5724)]
    public class GcTechList : GameComponentType {

        public List<NMSString0x10> AvailableTech;
    }
}
