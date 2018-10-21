﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x33EED7714D4189E8)]
    public class GcGalaxySolarSystemParams : GameComponentType {

        /* 0x00 */ public GcGalaxySolarSystemOrbitParams PlanetParameters;
        /* 0x1C */ public GcGalaxySolarSystemOrbitParams MoonParameters;
        [NMS(Size = 0x4, EnumValue = new[] { "Large", "Medium", "Small", "Moon" })]
        /* 0x38 */ public float[] PlanetRadii;
        /* 0x48 */ public float SystemTilt;                 // 41700000h
        /* 0x4C */ public float DefaultDistance;            // 41200000h
        /* 0x50 */ public float VisitedPlanetAlpha;         // 3F800000h
        /* 0x54 */ public float NonVisitedPlanetAlpha;      // 3ECCCCCDh
    }
}
