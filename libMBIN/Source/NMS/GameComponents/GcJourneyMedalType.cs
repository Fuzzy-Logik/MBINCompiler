﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x51E71BE7A4534E21)]
    public class GcJourneyMedalType : GameComponentType {

		public enum MedalTypeEnum { Standings, Missions, Words, Systems, Sentinels, Pirates, Plants, Units, RaceCreatures, DistanceWarped }
		public MedalTypeEnum MedalType;
    }
}
