﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x54, GUID = 0x2134F28E3C1FC07E)]
    public class GcCameraWarpSettings : GameComponentType {

        public float FocusPointDist;
        public float OffsetZFrequency_1;
        public float OffsetZFrequency_2;
        public float OffsetZPhase_1;
        public float OffsetZPhase_2;
        public float OffsetZStartBias;
        public float OffsetZBias;
        public float OffsetZRange;
        public float OffsetYFrequency_1;
        public float OffsetYFrequency_2;
        public float OffsetYPhase_1;
        public float OffsetYPhase_2;
        public float OffsetYStartBias;
        public float OffsetYBias;
        public float OffsetYRange;
        public float OffsetXFrequency;
        public float OffsetXPhase;
        public float OffsetXRange;
        public TkCurveType OffsetXCurve;
        public float RollRange;
        public float YawnRange;
    }
}
