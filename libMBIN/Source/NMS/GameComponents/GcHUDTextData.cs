﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x738CDF94ACD0CC0A)]
    public class GcHUDTextData : GameComponent {

        public GcHUDComponent Data;

        [NMS(Size = 0x80)]
        public string Text;

        [NMS(Size = 8, Ignore = true)]
        public byte[] PaddingA8;

        public GcTextPreset Preset;
    }
}
