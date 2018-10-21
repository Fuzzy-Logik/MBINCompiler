﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x21E266137C8188B8)]
    public class TkAnimPoseExampleElement : ToolkitComponent {

        [NMS(Size = 0x10)]
        public string Anim;
        public float Value;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
