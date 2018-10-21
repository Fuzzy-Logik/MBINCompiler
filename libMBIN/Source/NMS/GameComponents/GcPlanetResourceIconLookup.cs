﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x118, GUID = 0xCE724D5DF7B4C68E)]
    public class GcPlanetResourceIconLookup : GameComponent {

        [NMS(Size = 0x10)]
        public string ID;
        public TkTextureResource Icon;
        public TkTextureResource IconBinocs;
    }
}
