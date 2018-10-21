﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14, GUID = 0xFF1A0BCD4F36D412)]
    public class GcRewardWeapon : GameComponent {

        public GcRarity Rarity;
        public int ItemLevel;
        public int AmountMin;
        public int AmountMax;
        public bool MarkInteractionComplete;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
