﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0xB164EA8EF150DFDC)]
    public class GcAISpaceshipWeightingData : GameComponent {

        [NMS(Size = 0x7, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter", "Royal" })]
        public float[] CivilianClassWeightings;
    }
}
