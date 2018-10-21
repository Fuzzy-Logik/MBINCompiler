﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x8999A8B76829CCD5)]
    public class TkLSystemInnerRule : ToolkitData {

        [NMS(Size = 0x20)]
        public string LocatorType;
		public enum MergeProbabilityOptionsEnum { Balance, Prioritize, Replace }
		public MergeProbabilityOptionsEnum MergeProbabilityOptions;

        public List<TkLSystemLocatorEntry> Entries;
    }
}
