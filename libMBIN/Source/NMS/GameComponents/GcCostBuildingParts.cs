﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA50B10766E494BB3)]
    public class GcCostBuildingParts : GameComponent {

        [NMS(Size = 0x20)]
        public string Description;
        public List<GcBuildingCostPartCount> RequiredParts;
    }
}
