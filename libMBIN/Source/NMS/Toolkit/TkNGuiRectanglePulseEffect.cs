﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x7AACCA8A1F8AE79F)]
    public class TkNGuiRectanglePulseEffect : ToolkitData {

        public float PulseWidth;                // 40C00000h
        public float PulseOffset;               // 42200000h
        public float PulseRate;                 // 3F99999Ah
        public TkCurveType PulseAlphaCurve;
        public TkCurveType PulseSizeCurve;
    }
}
