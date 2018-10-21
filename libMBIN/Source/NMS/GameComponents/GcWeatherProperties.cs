﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x610, GUID = 0x604FAE2ECBA08F97)]
    public class GcWeatherProperties : GameComponent {

        [NMS(Size = 0x10)]
        /* 0x000 */ public string Name;

        /* 0x010 */ public GcFogProperties Fog;
        /* 0x0EC */ public GcFogProperties FlightFog;
        /* 0x1C8 */ public GcFogProperties ExtremeFog;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2A4 */ public byte[] Padding2A4;

        /* 0x2B0 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        /* 0x520 */ public List<GcStormProperties> Storms;

        /* 0x530 */ public List<NMSString0x80> HeavyAir;

        /* 0x540 */ public float LowStormsChance;
        /* 0x544 */ public float HighStormsChance;
        /* 0x548 */ public float ExtremeWeatherChance;

        /* 0x54C */ public bool OverrideTemperature;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x54D */ public byte[] Padding54D;
        [NMS(Size = 0x5)]
        /* 0x550 */ public GcHazardValues[] Temperature;

        /* 0x578 */ public bool OverrideToxicity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x579 */ public byte[] Padding579;
        [NMS(Size = 0x5)]
        /* 0x57C */ public GcHazardValues[] Toxicity;

        /* 0x5A4 */ public bool OverrideRadiation;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5A5 */ public byte[] Padding5A5;
        [NMS(Size = 0x5)]
        /* 0x5A8 */ public GcHazardValues[] Radiation;
        [NMS(Size = 0x5)]
        /* 0x5D0 */ public GcHazardValues[] LifeSupportDrain;
        /* 0x5F8 */ public List<GcScreenFilters> StormFilterOptions;        // dummy variable
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x608 */ public byte[] EndPadding;
    }
}
