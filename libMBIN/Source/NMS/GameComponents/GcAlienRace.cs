﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x17C1F3DED0C039C3)]
    public class GcAlienRace : GameComponentType {

        public enum AlienRaceEnum { Traders, Warriors, Explorers, Robots, Atlas, Diplomats, None }
        public AlienRaceEnum AlienRace;
    }
}
