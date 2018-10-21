﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0x87068490DC83B1C1)]
    public class TkAttachmentData : ToolkitComponent {

        /* 0x00 */ public List<GameComponent> Components;
        [NMS(Size = 0x5)]
        /* 0x10 */ public float[] LodDistances;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
