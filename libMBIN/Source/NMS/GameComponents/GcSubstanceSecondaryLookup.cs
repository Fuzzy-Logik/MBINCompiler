﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCED0783DBCA95F60)]
    public class GcSubstanceSecondaryLookup : GameComponentType {

        [NMS(Size = 0x10)]
        public string PrimaryID;
        public List<GcSubstanceSecondary> SecondaryChances;
    }
}
