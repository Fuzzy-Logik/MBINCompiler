﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3E20, GUID = 0x2E5394FAA803E803)]
    public class GcCustomisationUIData : GameComponent {

        [NMS(Size = 0xE)]
        public GcCustomisationUI[] CustomisationUIData;
    }
}
