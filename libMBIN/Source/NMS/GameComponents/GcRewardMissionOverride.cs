﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFEC2385BD37C76F6)]
    public class GcRewardMissionOverride : GameComponentType {

        [NMS(Size = 0x10)]
        public string Mission;
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
