﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC9FFFC7A5A173EEC)]
    public class GcMissionConditionFrigateCount : GameComponent {

        public int FrigateCount;
        public TkEqualityEnum Test;
    }
}
