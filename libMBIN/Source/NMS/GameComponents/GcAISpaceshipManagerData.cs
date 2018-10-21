﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8C3E63EA3A2D7991)]
    public class GcAISpaceshipManagerData : GameComponent {

        [NMS(Size = 5, EnumValue = new string[5] { "Player", "Civilian", "Pirate", "Police", "Creature" })]
        public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
