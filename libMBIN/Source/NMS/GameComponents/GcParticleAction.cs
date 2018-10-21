﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x38364E77B204C4F3)]
    public class GcParticleAction : GameComponent {

        [NMS(Size = 0x10)]
        public string Effect;
        [NMS(Size = 0x20)]
        public string Joint;
        public bool Exact;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding31;
    }
}
