﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x843A3DAF82E8DFDF)]
    public class GcTileTypeSet : GameComponent {

        public float Probability;

        [NMS(Size = 0xC)]
        public TkPaletteTexture[] Colours;
    }
}
