﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3AC56A6710928927)]
    public class GcSelectableObjectData : GameComponent {

        [NMS(Size = 0x80)]
        public string Filename;
    }
}
