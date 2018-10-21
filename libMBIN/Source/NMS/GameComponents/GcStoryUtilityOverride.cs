﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x89968B9F613A0032)]
    public class GcStoryUtilityOverride : GameComponent {

        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
