﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x6DC0671B6D868B21)]
    public class TkButtonPathMapping : ToolkitData {

        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x80)]
        public string Path;
    }
}
