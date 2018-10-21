﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x68F78A981C698B29)]
    public class GcTextStyleOutline : GameComponentType {

        public Colour OutlineColour;
        public Vector2f OutlineOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
