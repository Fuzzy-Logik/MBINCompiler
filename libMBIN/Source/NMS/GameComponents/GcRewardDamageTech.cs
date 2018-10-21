﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xDE8F18A1FD0B2736)]
    public class GcRewardDamageTech : GameComponent {

        public GcTechnologyCategory Category;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Paddding4;
        [NMS(Size = 0x10)]
        public string TechToDamage_optional;
        public bool ShowDamageMessage;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
