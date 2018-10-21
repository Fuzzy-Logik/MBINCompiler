﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0xEFADC778D8A5950B)]
    public class GcFreighterBaseOption : GameComponent {

        [NMS(Size = 0x80)]
        public string BaseDataFile;
        public float ProbabilityWeighting;
    }
}
