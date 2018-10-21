﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8E0C4DD242A5FA5D)]
    public class GcPlayerStatsGroup : GameComponentType {

        [NMS(Size = 0x10)]
        public string GroupId;

        public ulong Address;

        public List<GcPlayerStat> Stats;
    }
}
