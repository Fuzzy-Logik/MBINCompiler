﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xC77EEE2A066CE101)]
    public class TkLanguageFontTableEntry : ToolkitData {

        public TkLanguages Language;
        [NMS(Size = 0x80)]
        public string GameFont;
        [NMS(Size = 0x80)]
        public string GameFont2;
        [NMS(Size = 0x80)]
        public string ConsoleFont;
    }
}
