﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x5BB8EE88949205C4)]
    public class GcStatsBonus : GameComponent {

        public GcStatsTypes StatsTypes;
        public float Bonus;
        public int Level;
    }
}
