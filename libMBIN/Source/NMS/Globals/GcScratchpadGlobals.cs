﻿using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals {

    [NMS( GUID = 0xC14472951E47BFF8 )]
    public class GcScratchpadGlobals : GlobalDataStruct {

        [NMS(Size = 0xE)]
        /* 0x0 */ public GcPresetTextureData[] IBLMaps;
        [NMS(Size = 0xA)]
        /* 0x1500 */ public GcPresetTextureData[] TerrainTextures;
        [NMS(Size = 0x2)]
        /* 0x2400 */ public GcPresetTextureData[] OverlayTextures;
        [NMS(Size = 0xD)]
        /* 0x2700 */ public Colour[] TerrainColours;

    }

}
