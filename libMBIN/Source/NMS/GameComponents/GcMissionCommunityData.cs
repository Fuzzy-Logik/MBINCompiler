﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x217A1A17636245C1, Size = 0x10)]
    public class GcMissionCommunityData : GameComponentType {

        public List<NMSString0x10> CommunityMissionsIDs;
    }
}
