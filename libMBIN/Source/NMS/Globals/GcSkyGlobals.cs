﻿using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals {

    [NMS( GUID = 0x18B789779D43057A )]
    public class GcSkyGlobals : GlobalDataType {

        /* 0x0 */ public float NightThreshold;
        /* 0x4 */ public GcPhotoModeAdjustData FogAdjust;
        /* 0x1C */ public GcPhotoModeAdjustData CloudAdjust;
        /* 0x34 */ public GcPhotoModeAdjustData VignetteAdjust;
        /* 0x4C */ public TkCurveType DoFAdjustMagnitudeMaxCurve;
        /* 0x50 */ public int DayLength;
        /* 0x54 */ public bool EnableDayNightCycle;

        [NMS(Size = 0xB, Ignore = true)]
        /* 0x55 */ public byte[] Padding55;

        /* 0x60 */ public Vector4f SunRotationAxis;
        /* 0x70 */ public int SafeSkyMinIndex;
        /* 0x74 */ public int SafeSkyMaxIndex;
        /* 0x78 */ public int FrozenSkyMinIndex;
        /* 0x7C */ public int FrozenSkyMaxIndex;
        /* 0x80 */ public float SunClampAngle;
        /* 0x84 */ public float PhotoModeSunSpeed;
        /* 0x88 */ public float FreshStartTimeOfDay;
        /* 0x8C */ public bool ForceStormSetting;
        /* 0x90 */ public float ForceStormStrength;
        /* 0x94 */ public float StormScreenFilterFadeTime;
        /* 0x98 */ public float StormScreenFilterDistance;
        /* 0x9C */ public float MinTimeBetweenStormsLow;
        /* 0xA0 */ public float MaxTimeBetweenStormsLow;
        /* 0xA4 */ public float MinTimeBetweenStormsHigh;
        /* 0xA8 */ public float MaxTimeBetweenStormsHigh;
        /* 0xAC */ public float MinStormLengthLow;
        /* 0xB0 */ public float MaxStormLengthLow;
        /* 0xB4 */ public float MinStormLengthHigh;
        /* 0xB8 */ public float MaxStormLengthHigh;
        /* 0xBC */ public float StormWarningTime;
        /* 0xC0 */ public float StormTransitionTime;
        /* 0xC4 */ public bool ForceFlightSetting;
        /* 0xC8 */ public float ForceFlightStrength;
        /* 0xCC */ public float ToFootFadeTime;
        /* 0xD0 */ public float ToFlightFadeTime;
        /* 0xD4 */ public float InFlightStormStrength;
        /* 0xD8 */ public float CreatureStormThreshold;
        /* 0xDC */ public float TakeoffStormThreshold;
        /* 0xE0 */ public float ExtremeAudioLevel;
        /* 0xE4 */ public float StormAudioLevel;
        /* 0xE8 */ public bool SleepSunFromSettings;
        /* 0xF0 */ public Vector4f SleepSunFromSettingsPos;
        /* 0x100 */ public Vector4f SunPosition;
        /* 0x110 */ public Colour AsteroidColour;
        /* 0x120 */ public Colour DayLightColour;
        /* 0x130 */ public Colour NightLightColour;
        /* 0x140 */ public Colour DuskLightColour;
        /* 0x150 */ public Colour NightHeavyAirColour;
        /* 0x160 */ public Colour SpaceLightColour;
        /* 0x170 */ public float HeavyAirScale;
        /* 0x174 */ public float AmbientFactor;
        /* 0x178 */ public float MinSunsetFade;
        /* 0x17C */ public float MaxSunsetFade;
        /* 0x180 */ public float MinSunsetHorizonFade;
        /* 0x184 */ public float MaxSunsetHorizonFade;
        /* 0x188 */ public float MinNightFade;
        /* 0x18C */ public float MaxNightFade;
        /* 0x190 */ public float MinSunsetPosFade;
        /* 0x194 */ public float MaxSunsetPosFade;
        /* 0x198 */ public float MinSunsetFogFade;
        /* 0x19C */ public float MaxSunsetFogFade;
        /* 0x1A0 */ public float MinSunsetAtmosphereFade;
        /* 0x1A4 */ public float MaxSunsetAtmosphereFade;
        /* 0x1A8 */ public float MinSunsetColourFade;
        /* 0x1AC */ public float MaxSunsetColourFade;
        /* 0x1B0 */ public float MinSaturation;
        /* 0x1B4 */ public float MaxSaturation;
        /* 0x1B8 */ public float MinValue;
        /* 0x1BC */ public float MaxValue;
        /* 0x1C0 */ public float MinFogSaturation;
        /* 0x1C4 */ public float MaxFogSaturation;
        /* 0x1C8 */ public float MinFogValue;
        /* 0x1CC */ public float MaxFogValue;
        /* 0x1D0 */ public float MinColourS;
        /* 0x1D4 */ public float MaxColourS;
        /* 0x1D8 */ public float MinColourV;
        /* 0x1DC */ public float MaxColourV;
        /* 0x1E0 */ public float MulticolourH;
        /* 0x1E4 */ public float NebulaColourH;
        /* 0x1E8 */ public float NebulaColour1S;
        /* 0x1EC */ public float NebulaColour1V;
        /* 0x1F0 */ public float NebulaColour2S;
        /* 0x1F4 */ public float NebulaColour2V;
        /* 0x1F8 */ public float MidColourH;
        /* 0x1FC */ public float MidColourS;
        /* 0x200 */ public float MidColourV;
        /* 0x204 */ public float CloudColourH;
        /* 0x208 */ public float CloudColourS;
        /* 0x20C */ public float CloudColourV;
        /* 0x210 */ public float NebulaShadow;
        /* 0x214 */ public float SpaceAtmosphereThickness;
        /* 0x218 */ public float WaterHeavyAirAlpha;
        /* 0x21C */ public float NightHorizonBlendMin;
        /* 0x220 */ public float NightHorizonBlendMax;
        /* 0x224 */ public float NightSkyBlendMin;
        /* 0x228 */ public float NightSkyBlendMax;
        /* 0x22C */ public float NightLightBlendMin;
        /* 0x230 */ public float NightLightBlendMax;
        /* 0x234 */ public bool ForceNightBlend;
        /* 0x238 */ public float ForceNightBlendValue;
        /* 0x23C */ public float NoAtmosphereFogStrength;
        /* 0x240 */ public float NoAtmosphereFogMax;
        /* 0x244 */ public float NoAtmosphereColourStrength;
        /* 0x248 */ public float NoAtmosphereColourMax;
        /* 0x24C */ public float LowFlightFogThreshold;
        /* 0x250 */ public GcSkyProperties PlanetSky;
        /* 0x280 */ public GcFogProperties PlanetFog;
        /* 0x35C */ public GcFogProperties PlanetExtremeFog;
        /* 0x438 */ public GcFogProperties PlanetStormFog;
        /* 0x514 */ public GcFogProperties PlanetFlightFog;
        /* 0x5F0 */ public GcSpaceSkyProperties SpaceSkyMin;
        /* 0x690 */ public GcSpaceSkyProperties SpaceSkyMax;
        [NMS(Size = 4)]
        /* 0x730 */ public GcSpaceSkyColours[] SpaceSkyColours;
        /* 0xAB0 */ public GcPlanetWeatherColourData NightSkyColours;
        /* 0xB60 */ public float HackSpaceInterp1;
        /* 0xB64 */ public float HackSpaceInterp2;
        /* 0xB68 */ public int HackSpaceColourIndex;
        /* 0xB70 */ public Colour HeavyAirColour1;
        /* 0xB80 */ public Colour HeavyAirColour2;
        /* 0xB90 */ public Colour NightHorizonColour;
        /* 0xBA0 */ public Colour NightSkyColour;
        /* 0xBB0 */ public Colour NightFogColour;
        /* 0xBC0 */ public Colour NightHeightFogColour;
        /* 0xBD0 */ public GcPlanetCloudProperties PlanetCloudsMin;
        /* 0xBF8 */ public GcPlanetCloudProperties PlanetCloudsMax;

    }

}
