﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1C14B0D6CD418514)]
    public class GcMissionCategory : GameComponent {

		public enum MissionCategoryEnum { Info, Mission, Danger, Urgent }
		public MissionCategoryEnum MissionCategory;
    }
}
