﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x10BF34C1048FA823)]
    public class GcMissionPageHint : GameComponent {

		public enum MissionPageHintEnum { None, Suit, Ship, Weapon, Vehicle, Freighter, Wiki, MissionLog, Discovery, Journey }
		public MissionPageHintEnum MissionPageHint;
    }
}
