﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x36E3CF6D7FBAA203)]
    public class GcCustomisationTextureOptions : GameComponent {

        public List<GcCustomisationTextureOption> TextureOptions;
    }
}
