﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF0196F209D21EB12)]
    public class GcRewardJourneyThroughCentre : GameComponentType {

		public enum CentreJourneyDestinationEnum { Next, Abandoned, Vicious, Lush, Balanced }
		public CentreJourneyDestinationEnum CentreJourneyDestination;
    }
}
