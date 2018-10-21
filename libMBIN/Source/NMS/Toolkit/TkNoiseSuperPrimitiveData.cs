﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xA5204789BF9D0341)]
    public class TkNoiseSuperPrimitiveData : ToolkitComponent {

        public float Width;
        public float Height;
        public float Depth;
        public float Thickness;
        public float CornerRadiusXY;
        public float CornerRadiusZ;
        public float BottomRadiusOffset;
    }
}
