﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCCC237984F4D9D40)]
    public class GcCreatureComponentData : GameComponent {

        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis Axis;
        public float Scaler;
    }
}
