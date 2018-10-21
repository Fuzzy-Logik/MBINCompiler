﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBD8A1BAD12326FE2)]
    public class GcAISpaceshipInstanceData : GameComponent {

        [NMS(Size = 0x80)]
        public string File;
    }
}
