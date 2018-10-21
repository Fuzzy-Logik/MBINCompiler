﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xAF69A920435DE7D)]
    public class GcCustomisationColourGroup : GameComponentType {

        [NMS(Size = 0x10)]
        public string GroupID;
        [NMS(Size = 0x20)]
        public string Title;
        public TkPaletteTexture Palette;
    }
}
