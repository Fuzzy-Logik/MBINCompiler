﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF4F93A0ED2B84F61)]
    public class GcMissionConditionFactionRank : GameComponentType {

        public GcMissionFaction Faction;        // I think?
        public bool UseSystemRace;
        public int Rank;
    }
}
