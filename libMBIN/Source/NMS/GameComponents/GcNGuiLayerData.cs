﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x10, Size = 0x310, GUID = 0x5E9A900228C5334B)]
    public class GcNGuiLayerData : GameComponent {

        /* 0x000 */ public GcNGuiElementData Data;
        /* 0x050 */ public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        /* 0x200 */ public string Image;
        /* 0x280 */ public List<GameComponent> Children;
        [NMS(Size = 0x80)]
        /* 0x290 */ public string DataFilename;
    }
}
