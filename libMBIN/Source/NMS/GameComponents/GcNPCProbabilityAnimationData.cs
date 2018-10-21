﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xFECDFAAE257D62DC)]
    public class GcNPCProbabilityAnimationData : GameComponent {

        [NMS(Size = 0x10)]
        public string Name;
        public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
