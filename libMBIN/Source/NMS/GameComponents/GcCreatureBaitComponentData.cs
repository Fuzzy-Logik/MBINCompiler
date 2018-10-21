﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4DDDBDFBD1267CE7)]
    public class GcCreatureBaitComponentData : GameComponent {

        public List<NMSString0x10> AttractList;
        public float BaitStrength;
        public float BaitRadius;

        public bool Debug;
        public bool InducesRage;

        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding1A;
    }
}
