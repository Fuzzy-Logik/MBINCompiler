﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xCDD1753E3C085C69)]
    public class GcHazardAction : GameComponentType {

        public GcHazardModifiers Hazard;
        public float Strength;
        public float Radius;
        public bool RadiusBasedStrength;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
