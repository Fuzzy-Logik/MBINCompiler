﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x943A716913810596)]
    public class GcWikiPage : GameComponentType {

        [NMS(Size = 0x20)]
        /* 0x000 */ public string PageID;
        /* 0x020 */ public TkTextureResource Icon;
        [NMS(Size = 0x40)]
        /* 0x0A4 */ public string Content;
        /* 0x0E4 */ public TkTextureResource ContentImage;
    }
}
