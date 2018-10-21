﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA0814A4C94B662F6)]
    public class GcScanEventTriggers : GameComponentType {

        public float Range;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<NMSString0x10> Triggers;
        public bool AllowRetrigger;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
