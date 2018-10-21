﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x4C98B666C4454E5A)]
    public class TkLSystemGlobalRestriction : ToolkitComponent {

        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public List<TkLSystemRestrictionData> Restrictions;
    }
}
