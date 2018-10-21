﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xB0, GUID = 0x2860E63449C8ACD8)]
    public class TkAnimVectorBlendNodeData : ToolkitDataType {

        [NMS(Size = 0x10)]
        public string NodeId;
        [NMS(Size = 0x40)]
        public string WeightIn;
        public float WeightRangeBegin;
        public float WeightRangeEnd;
        public float WeightSpringTime;
        public TkCurveType WeightCurve;
        public float InitialWeight;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding64;
        public NMSTemplate BlendChild;
    }
}
