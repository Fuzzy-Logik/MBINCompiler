﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x483E6945FC60E4E1)]
    public class GcNGuiElementData : GameComponentType {

        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string PresetID;

        /* 0x20 */ public bool IsHidden;

        [NMS(Size = 0x3, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;

        /* 0x24 */ public GcNGuiLayoutData Layout;
    }
}
