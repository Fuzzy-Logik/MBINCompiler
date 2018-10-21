﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4A07C0F132712212)]
    public class GcBirdData : GameComponent {

        public float FlapSpeedMax;
        public float FlapSpeedMin;
        public float FlapSpeed;
        public float FlapAccel;

        [NMS(Size = 0x80)]
        public string CircleAttractor;
    }
}
