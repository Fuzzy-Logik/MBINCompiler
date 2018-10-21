﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBCE880E6CBE6D9EC)]
    public class GcRealitySubstanceCraftingMix : GameComponent {

        [NMS(Size = 0x10)]
        public string ID;

        public int Ratio;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
