﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x84, GUID = 0x8F308DA13045525E)]
    public class TkTextureResource : ToolkitDataType {

        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Ignore = true)]
        public int EmptyNode1;
    }
}
