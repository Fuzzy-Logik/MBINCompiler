﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xF6AEDCB258E2CFC1)]
    public class TkResourceFilterData : ToolkitData {

        [NMS(Size = 0x10)]
        public string FilterName;
        public List<NMSString0x20> FilteredResources;

    }
}
