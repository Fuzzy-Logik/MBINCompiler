﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x602CB74A9031204B)]
    public class TkGeometryStreamData : ToolkitComponent {

        /* 0x00 */ public List<TkMeshData> StreamDataArray;
    }
}
