﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x54366264A902610C)]
    public class GcEntitlementRewardData : GameComponentType {

        [NMS(Size = 0x10)]
        public string EntitlementId;

        [NMS(Size = 0x10)]
        public string RewardId;

        [NMS(Size = 0x20)]
        public string Name;

        [NMS(Size = 0x20)]
        public string Error;
    }
}
