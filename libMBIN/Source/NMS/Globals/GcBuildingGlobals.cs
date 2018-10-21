﻿using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals {

    [NMS( GUID = 0x6ABE798B8E148B68 )]
    public class GcBuildingGlobals : GlobalDataStruct {

        /* 0x0 */ public bool AllowBuildingUsingIntermediates;
        /* 0x4 */ public float BuildingLineFadeStart;
        /* 0x8 */ public float BuildingLineFadeEnd;
        /* 0xC */ public float BuildingLineAlpha;
        /* 0x10 */ public float BuildingLineWidth;
        /* 0x14 */ public float BuildingLineMoveSpeed;
        /* 0x18 */ public float BuildingLineMoveAmount;
        /* 0x1C */ public float BuildingLineShrink;
        /* 0x20 */ public float BuildingLineMaxSize;
        /* 0x24 */ public int BuildingLineCount;
        /* 0x28 */ public float IconSpringTime;
        /* 0x2C */ public float HoverFadeAlpha;
        /* 0x30 */ public float HoverTime;
        /* 0x34 */ public float HoverVisibilityTime;
        /* 0x38 */ public float HoverFadeTime;
        /* 0x3C */ public float HoverMinToStayActiveTime;
        /* 0x40 */ public float HoverStayActiveTime;
        /* 0x44 */ public float HoverLockedInitTime;
        /* 0x48 */ public float HoverLockedActiveTime;
        /* 0x4C */ public float HoverLockedIconScale;
        /* 0x50 */ public float HoverInactiveSize;
        /* 0x54 */ public float LineMinDistance;
        /* 0x58 */ public float LineDistanceRange;
        /* 0x5C */ public float MaxLineLength;
        /* 0x60 */ public float MinLineLength;
        /* 0x64 */ public TkCurveType LineCurve;
        /* 0x68 */ public float BuildingYOffset;
        /* 0x6C */ public float InteractMarkerYOffset;
        /* 0x70 */ public float MinRadius;
        /* 0x74 */ public float FadeRadius;
        /* 0x78 */ public float CloseFadeRadius;
        /* 0x7C */ public float CloseScaleRadius;
        /* 0x80 */ public float PlanetSectorSize;
        /* 0x84 */ public float ChanceOfAddingShelter;
        /* 0x88 */ public float SectorMessageReshowDistance;
        /* 0x8C */ public float SectorMessageCenterDistance;
        /* 0x90 */ public float SectorMessageMinTime;
        /* 0x94 */ public float MinTimeBetweenBuildingEntryMessage;
        /* 0x98 */ public float FadeStart;
        /* 0x9C */ public float FadeDistance;
        /* 0xA0 */ public float NearMinAlpha;
        /* 0xA4 */ public float MinAlpha;
        /* 0xA8 */ public float LineScaleFactor;
        /* 0xAC */ public float BuildingNearDistance;
        /* 0xB0 */ public float BuildingNearArcDistance;
        /* 0xB4 */ public float BuildingVisitDistance;
        /* 0xB8 */ public float NearMaxLineLength;
        /* 0xBC */ public float NearMinLineLength;
        /* 0xC0 */ public float NearLineScaleFactor;
        /* 0xC4 */ public float MinElevatedHeight;
        /* 0xC8 */ public float MaxLowHeight;
        /* 0xCC */ public float TextStringXOffset;
        /* 0xD0 */ public float TextTagXOffset;
        /* 0xD4 */ public float TextTagYOffset;
        /* 0xD8 */ public float TextTagWidthOffset;
        /* 0xDC */ public float DistanceTextXOffset;
        /* 0xE0 */ public float DistanceTagXOffset;
        /* 0xE4 */ public float TextTagLength;
        /* 0xE8 */ public float DistanceForVisited;
        /* 0xEC */ public float DistanceForTooltip;
        /* 0xF0 */ public float SmallIconSize;
        /* 0xF4 */ public float LargeIconSize;
        /* 0xF8 */ public float LargeIconArrowOffset;
        /* 0xFC */ public float CompassIconSize;
        /* 0x100 */ public float SmallIconArrowOffset;
        /* 0x104 */ public float SpaceMarkerOffset;
        /* 0x108 */ public float SpaceMarkerOffsetPlanet;
        /* 0x10C */ public float SpaceMarkerOffsetSamePlanet;
        /* 0x110 */ public float MarkerLineWidth;
        /* 0x120 */ public Colour MarkerLineColour;
        /* 0x130 */ public float AmountToMoveMarkerRoundSphere;
        /* 0x134 */ public float MarkerTransitionDistance;
        /* 0x138 */ public float SpaceMarkerMinHeight;
        /* 0x13C */ public float SpaceMarkerMaxHeight;
        /* 0x140 */ public float MaxTimeBetweenEvents;
        /* 0x144 */ public float ShowTimeNotDistance;
        /* 0x148 */ public float UnknownBuildingRange;
        /* 0x14C */ public float MaxIconRange;
        /* 0x150 */ public float MarkerTimeIncrease;
        /* 0x154 */ public float FlyingBuildingIconTime;
        /* 0x158 */ public int MinShipScanBuildings;
        /* 0x15C */ public int MaxShipScanBuildings;
        /* 0x160 */ public float MinRadiusForBases;
        /* 0x164 */ public float BaseRadiusExtension;
        /* 0x168 */ public float MaxRadiusForBases;
        /* 0x16C */ public float BuildingPlacementMaxDistance;
        /* 0x170 */ public float BuildingPlacementSphereCastRadius;
        /* 0x174 */ public float BuildingPlacementSphereCastBefore;
        /* 0x178 */ public float BuildingPlacementSphereCastAfter;
        /* 0x17C */ public float BuildingPlacementAngleOffset;
        /* 0x180 */ public float BuildingPlacementAnglePower;
        /* 0x184 */ public float BuildingPlacementDepthPower;
        /* 0x188 */ public float BuildingPlacementDepthScale;
        /* 0x18C */ public float BuildingPlacementTwistScale;
        /* 0x190 */ public float BuildingPlacementDeviancePower;
        /* 0x194 */ public float BuildingPlacementMaxScore;
        /* 0x198 */ public int VisibleComplexityLimit;
        /* 0x19C */ public int InactiveVisibleComplexityLimit;
        /* 0x1A0 */ public float MaximumComplexityDensity;
        /* 0x1A4 */ public float ComplexityDensityTestRange;
        /* 0x1A8 */ public float ComplexityDensitySigmaSquared;
        /* 0x1AC */ public float StartCrashSiteMinDistance;
        /* 0x1B0 */ public float StartCrashSiteMaxDistance;
        /* 0x1B4 */ public float StartShelterMinDistance;
        /* 0x1B8 */ public float StartShelterMaxDistance;
        [NMS(Size = 0x80)]
        /* 0x1BC */ public string FreighterBaseSpawnOverride;
        /* 0x23C */ public bool BaseBuildingTerrainEditBoundsOverride;
        /* 0x240 */ public float BaseBuildingTerrainEditBaseYOffset;
        /* 0x244 */ public float BaseBuildingTerrainEditTopYOffset;
        /* 0x248 */ public float BaseBuildingTerrainEditBoundsScalar;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24C */ public byte[] EndPadding;

    }

}
