﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xD04D9D64AB1AC044)]
    public class TkMaterialData : ToolkitData {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x080 */ public string Class;
        /* 0x0A0 */ public int TransparencyLayerID;
        /* 0x0A4 */ public bool CastShadow;
        /* 0x0A5 */ public bool DisableZTest;
        [NMS(Size = 0x80)]
        /* 0x0A6 */ public string Link;
        [NMS(Size = 0x80)]
        /* 0x126 */ public string Shader;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1A6 */ public byte[] Padding1A6;
        /* 0x1A8 */ public List<TkMaterialFlags> Flags;
        /* 0x1B8 */ public List<TkMaterialUniform> Uniforms;
        /* 0x1C8 */ public List<TkMaterialSampler> Samplers;
    }
}
