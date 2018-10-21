﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x2D1C094801F11119)]
    public class TkIDArray : ToolkitDataType {

        public List<NMSString0x10> Array;
    }
}
