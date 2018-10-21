﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8BBDB1EEE1132923)]
    public class GcTextPresetTable : GameComponentType {

        public List<GcTextPreset> Table;
    }
}
