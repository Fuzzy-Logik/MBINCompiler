﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x4714DD868638194)]
    public class GcPlayerCharacterAnimationOverrideData : GameComponent {

        [NMS(Size = 0x10)]
        public string AnimName;
        public GcPlayerCharacterIKOverrideData Data;
    }
}
