﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA4768229DACCC1)]
    public class GcJourneyMilestoneTable : GameComponent {

        public List<GcJourneyMilestoneData> Table; // called GcJourneyMilestoneTable in the exe
    }
}
