﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xB2224162A8931EAF)]
    public class TkAudioAnimTrigger : ToolkitDataType {

        [NMS(Size = 0x80)]
        public string Sound;
        [NMS(Size = 0x10)]
        public string Anim;

        public int FrameStart;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding94;
    }
}
