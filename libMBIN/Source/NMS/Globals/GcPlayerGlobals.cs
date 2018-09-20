﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0xCA95DA5D4F24C1E5)]
    public class GcPlayerGlobals : NMSTemplate
    {
        /* 0x0 */ public bool InteractNearbyRadiusEnabled;
        /* 0x1 */ public bool DebugExperience;
        [NMS(Size = 0x80)]
		/* 0x2 */ public string DefaultShipFilename;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x82 */ public byte[] Padding82;
        /* 0x88 */ public GcSeed DefaultShipSeed;
		/* 0x98 */ public bool DebugExperienceRender;
		/* 0x99 */ public bool DebugDroneScanPlayer;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x9A */ public byte[] Padding9A;
		/* 0xA0 */ public Vector4f DebugDroneSpawn;
		/* 0xB0 */ public Vector4f DebugDroneTarget;
		/* 0xC0 */ public int DebugNumDrones;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xC4 */ public byte[] PaddingC4;
		/* 0xD0 */ public Vector4f DebugWalkerSpawn;
		/* 0xE0 */ public Vector4f DebugWalkerTarget;
		/* 0xF0 */ public Vector4f DebugFlybyTarget;
		/* 0x100 */ public Vector4f DebugFlybyDir;
		/* 0x110 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x114 */ public byte[] Padding114;
        /* 0x118 */ public GcSeed DebugFlybySeed;
        [NMS(Size = 0x10)]
        /* 0x128 */ public string DebugExperienceCamShake;       // maybe? or Vector4f
		/* 0x138 */ public float CockpitEjectTestRadius;
		/* 0x13C */ public float CockpitEjectTestStartHeightOffset;
		/* 0x140 */ public float CockpitEjectTestEndHeightOffset;
		/* 0x144 */ public float CockpitEjectFirstPersonOffsetTime;
		/* 0x148 */ public float CockpitEjectFirstPersonOffset;
		/* 0x14C */ public float MinBinocActiveTime;
		/* 0x150 */ public int RobotMultiplierWithFriends;
		/* 0x154 */ public float DroneStartLocationRadius;
		/* 0x158 */ public float ShipSummonLastSafeMargin;
		/* 0x15C */ public float CreativeModeDeathFadeInTime;
		/* 0x160 */ public float CreativeModeDeathFadeOutTime;
		/* 0x164 */ public int NumberOfWarpsRequiredForFreightersToSpawn;
		/* 0x168 */ public float SpawningDistanceBetweenPlayersAfterWarp;
		/* 0x16C */ public float SpawningSpaceBattleLookOffset;
		/* 0x170 */ public float SpawningSpaceBattleLookOffsetUp;
		/* 0x174 */ public bool MultiplayerShareWanted;
		/* 0x175 */ public bool ReportAllProjectileDamage;
		/* 0x178 */ public int DefaultHitPoints;
		/* 0x17C */ public int DefaultHealthPips;
		/* 0x180 */ public int DefaultShipHealthPips;
		/* 0x184 */ public int MaxHealthPips;
		/* 0x188 */ public bool UseLargeHealthBar;
		/* 0x18C */ public float DroneSpawnAccelerator;
		/* 0x190 */ public float TrackArrowStaticTargetOffsetMultiplier;
		/* 0x194 */ public float WitnessSenseEnhancementTime;
		/* 0x198 */ public float WitnessSenseEnhancement;
		/* 0x19C */ public float UnderwaterMargin;
		/* 0x1A0 */ public float MultiplayerMinWanteEscalationTime;
		/* 0x1A4 */ public float HealthRechargeMinTimeSinceDamage;
		/* 0x1A8 */ public float HealthPipRechargeRate;
		/* 0x1AC */ public float MinEnergyPercentOnRespawn;
		/* 0x1B0 */ public float VehicleRaceResultsHintTime;
		/* 0x1B4 */ public float OtherPlayerTrackArrowRange;
		/* 0x1B8 */ public float WantedLevelPlayerRange;
		/* 0x1BC */ public float WantedLevelPlayerRangeSpace;
		/* 0x1C0 */ public float PlayerTransferRange;
		/* 0x1C4 */ public float PlayerSpaceTransferRange;
		/* 0x1C8 */ public float DroneScanTimeToForget;
		/* 0x1CC */ public float GhostbusterStartLength;
		/* 0x1D0 */ public float GhostbusterStart1;
		/* 0x1D4 */ public float GhostbusterSpeed1;
		/* 0x1D8 */ public float GhostbusterFreq1;
		/* 0x1DC */ public float GhostbusterAmp1;
		/* 0x1E0 */ public float GhostbusterStart2;
		/* 0x1E4 */ public float GhostbusterSpeed2;
		/* 0x1E8 */ public float GhostbusterFreq2;
		/* 0x1EC */ public float GhostbusterAmp2;
		/* 0x1F0 */ public float GhostbusterStart3;
		/* 0x1F4 */ public float GhostbusterSpeed3;
		/* 0x1F8 */ public float GhostbusterFreq3;
		/* 0x1FC */ public float GhostbusterAmp3;
		/* 0x200 */ public bool WeaponZoomEnabled;
		/* 0x204 */ public float WeaponZoomFOV;
		/* 0x208 */ public float WeaponZoomRecoilMultiplier;
		/* 0x20C */ public float WeaponZoomVertRotation;
		/* 0x210 */ public float WeaponZoomHorzRotation;
		/* 0x214 */ public bool FrontShieldEnabled;
		/* 0x218 */ public float FrontShieldOffsetOff;
		/* 0x21C */ public float FrontShieldOffsetOn;
		/* 0x220 */ public float FrontShieldSpeedSlowdown;
		/* 0x224 */ public float CombatSpawnMinWantedTime;
		/* 0x228 */ public float ExperienceHardPiratesDamagePotentialMin;
		/* 0x22C */ public float ExperienceHardPiratesDamagePotentialRange;
		/* 0x230 */ public float ExperienceHardPiratesDamageMaxOdds;
		/* 0x234 */ public float ExperienceMediumPiratesDamagePotentialMin;
		/* 0x238 */ public float ExperienceMediumPiratesDamagePotentialRange;
		/* 0x23C */ public float ExperienceMediumPiratesDamageMaxOdds;
		/* 0x240 */ public float CommunicatorSpeed;
		/* 0x244 */ public float GrenadeBounceDamping;
		/* 0x248 */ public float GrenadeBounceMaxSpeed;
		/* 0x24C */ public float GrenadeStopExplodeTime;
		/* 0x250 */ public float CockpitEjectTestSphereRadius;
		/* 0x254 */ public float CockpitEjectTestSphereRange;
		/* 0x258 */ public float CockpitEjectSideTestRange;
		/* 0x25C */ public float WeaponShotgunSlowdown;
		/* 0x260 */ public int MouseSmoothMode;			// probably an enum associated with this...
		/* 0x264 */ public Vector2f MouseSpringStrength;
		/* 0x26C */ public Vector2f MouseSpringStrengthMinDelta;
		/* 0x274 */ public Vector2f MouseSpringStrengthMaxDelta;
		/* 0x27C */ public float HardModeEnergyDischargeRateLow;
		/* 0x280 */ public float HardModeEnergyDischargeRateMedium;
		/* 0x284 */ public float HardModeEnergyDischargeRateHigh;
		/* 0x288 */ public float HazardDamageMinTime;
		/* 0x28C */ public float EnergyDamageMinTime;
		/* 0x290 */ public float EnergyDischargeRateLow;
		/* 0x294 */ public float EnergyDischargeRateMedium;
		/* 0x298 */ public float EnergyDischargeRateHigh;
		/* 0x29C */ public float EnergyDischargeRateFloatingInSpace;
		/* 0x2A0 */ public float EnergyPainRate;
		/* 0x2A4 */ public float SolarRegenFactor;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2A4 */ public byte[] Padding2A4;
        /* 0x2B0 */ public Colour DefaultMuzzleColour;
        /* 0x2C0 */ public Colour TerrainEditorMuzzleColourSubtract;
        /* 0x2D0 */ public Colour TerrainEditorMuzzleColourAdd;
        /* 0x2E0 */ public Colour DefaultMuzzleLaserColour;
        /* 0x2F0 */ public float FreeJetpackRange;
        /* 0x2F4 */ public float FreeJetpackRangeNonTerrain;
        /* 0x2F8 */ public float JetpackDrainHorizontalFactor;
        /* 0x2FC */ public float MinTimeAfterMeleeBeforeBoost;
        /* 0x300 */ public float MaxTimeAfterMeleeBeforeBoost;
        /* 0x304 */ public float MeleeBoostAirForce;
        /* 0x308 */ public float MeleeToAirBoostInitialImpulse;
        /* 0x30C */ public float MaxTimeInMeleeBoost;
        /* 0x310 */ public bool RocketBootsEnabled;
        /* 0x311 */ public bool RocketBootsUseCustomCamera;
        /* 0x314 */ public float RocketBootsActivationWindow;
        /* 0x318 */ public float RocketBootsDoubleTapTime;
        /* 0x31C */ public float RocketBootsImpulse;
        /* 0x320 */ public float RocketBootsBoostForce;
        /* 0x324 */ public float RocketBootsDriftForce;
        /* 0x328 */ public float RocketBootsForceStartTime;
        /* 0x32C */ public float RocketBootsForceDuration;
        /* 0x330 */ public float RocketBootsMinDesiredHeight;
        /* 0x334 */ public float RocketBootsMaxDesiredHeight;
        /* 0x338 */ public float RocketBootsHeightAdjustTime;
        /* 0x33C */ public float RocketBootsHeightAdjustUpStrength;
        /* 0x340 */ public float RocketBootsHeightAdjustDownStrength;
        /* 0x344 */ public float RocketBootsJetpackMinLevel;
        /* 0x348 */ public float RocketBootsBoostTankDrainSpeed;
        /* 0x34C */ public float RocketBootsDriftTankDrainSpeed;
        /* 0x350 */ public float RocketBootsBoostOnTime;
        /* 0x354 */ public float RocketBootsBoostOffTime;
        /* 0x358 */ public float RocketBootsZigZagStrength;
        /* 0x35C */ public float RocketBootsZigZagForceDuration;
        /* 0x360 */ public float RocketBootsMaxSpeed;
        /* 0x364 */ public float RocketBootsDriftEndTime;
        /* 0x368 */ public float RocketBootsWindUpBraking;
        /* 0x36C */ public float RocketBootsDriftBraking;
        /* 0x370 */ public float RocketBootsDriftDownwardForce;
        /* 0x374 */ public float JetpackForce;
        /* 0x378 */ public float JetpackBrake;
        /* 0x37C */ public float JetpackMinLevel;
        /* 0x380 */ public float JetpackMaxSpeed;
        /* 0x384 */ public float JetpackMaxUpSpeed;
        /* 0x388 */ public float JetpackUpForce;
        /* 0x38C */ public float JetpackIgnitionForce;
        /* 0x390 */ public float JetpackIgnitionTime;
        /* 0x394 */ public float JetpackMinIgnitionTime;
        [NMS(Size = 0x3)]
        /* 0x398 */ public float[] JetpackTankTimes;
        /* 0x3A4 */ public float JetpackFillRate;
        /* 0x3A8 */ public float JetpackFillRateHardMode;
        /* 0x3AC */ public float JetpackFillRateSpaceStationMultiplier;
        /* 0x3B0 */ public float JetpackUpForceDeadPlanetExtra;
        /* 0x3B4 */ public float JetpackForceDeadPlanetExtra;
        /* 0x3B8 */ public float JetpackIgnitionForceDeadPlanetExtra;
        /* 0x3BC */ public bool EnableHeadMovements;
        /* 0x3BD */ public bool ClampPitch;
        /* 0x3C0 */ public float DamageRepairFactor;
        /* 0x3C4 */ public float DamageRepairFactorHardMode;
        /* 0x3C8 */ public float NormalModeHazardTimeMultiplier;
        /* 0x3CC */ public float NormalModeHazardDamageRateMultiplier;
        /* 0x3D0 */ public float NormalModeHazardDamageWoundRateMultiplier;
        /* 0x3D4 */ public float NormalModeSubstanceRewardMultiplier;
        /* 0x3D8 */ public float NormalModeHazardRechargeUnderground;
        /* 0x3DC */ public float HardModeHazardTimeMultiplier;
        /* 0x3E0 */ public float HardModeHazardDamageRateMultiplier;
        /* 0x3E4 */ public float HardModeHazardDamageWoundRateMultiplier;
        /* 0x3E8 */ public float HardModeSubstanceRewardMultiplier;
        /* 0x3EC */ public float HardModeHazardRechargeUnderground;
        /* 0x3F0 */ public float FreighterProbeScanTime;
        /* 0x3F4 */ public int MaxNumDestroyEffects;
        /* 0x3F8 */ public int MinNumDestroyEffects;
        /* 0x3FC */ public float ProjectileEndTime;
        /* 0x400 */ public float ExplosionTimePerEffect;
        /* 0x404 */ public float ExplosionTimeVariance;
        /* 0x408 */ public float ExplosionScaleVariance;
        /* 0x40C */ public float ExplosionBoundingInset;
        /* 0x410 */ public float ExplosionBoundingInsetRange;
        /* 0x414 */ public float DestroyEffectFinalDelay;
        /* 0x418 */ public float ShipPriceExp2;
        /* 0x41C */ public float WeaponPriceExp2;
        /* 0x420 */ public float FreighterPriceExp2;
        /* 0x424 */ public float ShipCoolFactor;
        /* 0x428 */ public float WeaponCoolFactor;
        /* 0x42C */ public float FreighterCoolFactor;
        /* 0x430 */ public bool MouseCrosshairVisible;
        /* 0x434 */ public float MouseMaxLength;
        /* 0x438 */ public float MouseDeadZone;
        /* 0x43C */ public float MouseAimZone;
        /* 0x440 */ public float MouseCrosshairMaxAlpha;
        /* 0x444 */ public float MouseCrosshairAlphaFade;
        /* 0x448 */ public float MouseCrosshairAlphaFadeSpeed;
        /* 0x44C */ public float MouseCrosshairLineAlpha;
        /* 0x450 */ public float MouseCrosshairLineWidth;
        /* 0x454 */ public float MouseCrosshairShipStrength;
        /* 0x458 */ public float MouseCrosshairMultiplier;
        /* 0x45C */ public bool UseEnergy;
        /* 0x45D */ public bool InventoryDamage;
        /* 0x45E */ public bool NeverPreyedOn;
        /* 0x45F */ public bool PermanantFire;
        /* 0x460 */ public bool PermanantAltFire;
        /* 0x461 */ public bool LuckyWithTech;
        /* 0x464 */ public int BulletCostReducer;
        /* 0x468 */ public int BulletClipMultiplier;
        /* 0x46C */ public float LootForceMultiplier;
        /* 0x470 */ public float WoundTimeMinimum;
        /* 0x474 */ public float WoundDamageLimit;
        /* 0x478 */ public float WoundDamageLimitShip;
        /* 0x47C */ public float WoundDamageDecayTime;
        /* 0x480 */ public float ResourceBlobFinalScaleDistance;
        /* 0x484 */ public float LaserPlayerOffset;
        /* 0x488 */ public float WalkerAlertRange;
        /* 0x48C */ public float WalkerSightRange;
        /* 0x490 */ public float WalkerSightAngle;
        /* 0x494 */ public float CombatEscalateTime;
        /* 0x498 */ public float CombatEscapeRadius;
        /* 0x49C */ public float CombatEscapeTime;
        /* 0x4A0 */ public bool UpgradeExosuitWithProduct;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x431 */ public byte[] Padding4A1;
        [NMS(Size = 0x10)]
        /* 0x4A8 */ public string ExosuitUpgradeProduct;
        /* 0x4B8 */ public int SuitInventoryStartSeed;
        /* 0x4BC */ public int MaxNumShipsAttackingPlayer;
        /* 0x4C0 */ public float ObjectScanTime;
        /* 0x4C4 */ public float DroneProbeScanTime;
        /* 0x4C8 */ public int PirateHailPercent;
        /* 0x4CC */ public float PirateBountyInitTime;
        /* 0x4D0 */ public float PirateProbeInitTime;
        /* 0x4D4 */ public float PirateProbeAttackWaitTime;
        /* 0x4D8 */ public float PirateProbeAttackWarnTime;
        /* 0x4DC */ public float PirateProbeScanTime;
        /* 0x4E0 */ public float PirateProbeScanTotalTime;
        /* 0x4E4 */ public float PirateProbeHailPause;
        /* 0x4E8 */ public float PirateBattleMarkerRange;
        /* 0x4EC */ public float PirateBattleWarnTime;
        /* 0x4F0 */ public float PirateBattleMarkerTime;
        /* 0x4F4 */ public float PirateBattleMaxTime;
        [NMS(Size = 0x20)]
        /* 0x4F8 */ public string TraderHailReceiveOSDLoc;
        [NMS(Size = 0x20)]
        /* 0x518 */ public string TraderHailRefusedOSDLoc;
        /* 0x538 */ public float TraderHailTime;
        /* 0x53C */ public float TraderApproachTime;
        /* 0x540 */ public float TraderHailDistance;
        /* 0x544 */ public float TraderApproachDistance;
        /* 0x548 */ public float TraderSpamTimeWait;
        /* 0x54C */ public float TraderStayCloseLockOffset;
        /* 0x550 */ public float TraderStayCloseLockSin1Coeff;
        /* 0x554 */ public float TraderStayCloseLockSin1Offset;
        /* 0x558 */ public float TraderStayCloseLockSin2Coeff;
        /* 0x55C */ public float TraderStayCloseLockSin2Offset;
        /* 0x560 */ public float TraderStayCloseLockSinsAdd;
        /* 0x564 */ public float TraderStayCloseLockSpread;
        /* 0x568 */ public float TraderStayCloseLockSpreadAdd;
        /* 0x56C */ public float TraderStayCloseLockSpreadTime;
        /* 0x570 */ public float TraderHealthFightThreshold;
        /* 0x574 */ public int TraderCommunicationBanMinTime;
        /* 0x578 */ public int TraderCommunicationBanMaxTime;
        /* 0x57C */ public float LaserMiningDamageMultiplier;
        /* 0x580 */ public float ShieldRechargeMinTimeSinceDamage;
        /* 0x584 */ public float ShieldRechargeRate;
        /* 0x588 */ public float MoveStickHighRangeLimit;
        /* 0x58C */ public float WitnessAIDamageDistance;
        /* 0x590 */ public float WitnessAIDamageAngle;
        /* 0x594 */ public float DeathDamageDrainChargeFactor;
        /* 0x598 */ public int DeathDamageTechBrokenPercent;
        /* 0x59C */ public float MaxProjectileRadiusMultiplier;
        /* 0x5A0 */ public float HardLandPainTime;
        /* 0x5A4 */ public int GunBaseClipSize;
        /* 0x5A8 */ public int GrenadeBaseClipSize;
        /* 0x5AC */ public float MeleeCooldown;
        /* 0x5B0 */ public float ChargeMeleeCooldown;
        /* 0x5B4 */ public float MeleeDistance;
        /* 0x5B8 */ public float MeleeDistance3P;
        /* 0x5BC */ public float MeleeRadius;
        /* 0x5C0 */ public float MeleeHitTime;
        /* 0x5C4 */ public float MeleeSpeedBoost;
        /* 0x5C8 */ public float MeleeSpeedDamageBoost;
        /* 0x5CC */ public float MeleeSpeedBoostRangeMultiplier;
        /* 0x5D0 */ public float MeleeStaminaDrain;
        /* 0x5D4 */ public float TemperatureDisplaySampleTime;
        /* 0x5E0 */ public Colour StarFieldColour;
        /* 0x5F0 */ public float StarFieldRadius;
        /* 0x5F4 */ public float StarFieldDensity;
        /* 0x5F8 */ public float StarFieldStarSize;
        /* 0x5FC */ public float SpeedLinesSpeedMin;
        /* 0x600 */ public float SpeedLinesSpeedMax;
        /* 0x604 */ public float SpeedLinesLength;
        /* 0x608 */ public float SpeedLinesTotalLength;
        /* 0x60C */ public float SpeedLinesWidthMin;
        /* 0x610 */ public float SpeedLinesWidthMax;
        /* 0x614 */ public float SpeedLinesRadiusStartMin;
        /* 0x618 */ public float SpeedLinesRadiusStartMax;
        /* 0x61C */ public float SpeedLinesRadiusIncrement;
        /* 0x620 */ public float SpeedLinesStartFade;
        /* 0x624 */ public float SpeedLinesMinAlpha;
        /* 0x628 */ public float SpeedLinesMaxAlpha;
        /* 0x62C */ public float SpeedLinesOffset;
        /* 0x630 */ public float SleepFadeTime;
        /* 0x634 */ public float StaminaRate;
        /* 0x638 */ public float StaminaRecoveryRate;
        /* 0x63C */ public float StaminaRecoveredFactor;
        /* 0x640 */ public float ScanLabelTime;
        /* 0x644 */ public float ScanWobbleFreq;
        /* 0x648 */ public float ScanWobbleAmp;
        /* 0x64C */ public float ScanWobbleFreq2;
        /* 0x650 */ public float ScanWobbleAmp2;
        /* 0x654 */ public float ScanRotate;
        /* 0x658 */ public float ScanRotateDist;
        /* 0x65C */ public float ScanRotateWobbleAmp;
        /* 0x660 */ public float ScanFadeInTime;
        /* 0x664 */ public float ScanFadeOutTime;
        /* 0x668 */ public float ScanBeamWidth;
        /* 0x66C */ public float ScanRotateBeamWdith;
        /* 0x670 */ public float ScanBeamMainWidth;
        /* 0x674 */ public float WantedDroneEventRadius;
        /* 0x678 */ public float WantedMinSpaceTime;
        /* 0x67C */ public float WantedMinPlanetTime;
        /* 0x680 */ public float WantedLevelDelay;
        /* 0x684 */ public float WantedWitnessTimer;
        /* 0x688 */ public float WantedWitnessFuzzyTime;
        /* 0x68C */ public float WantedMinorCrimeAmount;
        /* 0x690 */ public float WantedTimeoutAggressive;
        [NMS(Size = 0x5)]
        /* 0x694 */ public float[] WantedTimeout;
        [NMS(Size = 0x5)]
        /* 0x6A8 */ public float[] WantedEscalateTime;
        [NMS(Size = 0x5)]
        /* 0x6BC */ public float[] WantedExtremeEscalateTime;
        /* 0x6D0 */ public float ControlModes;
        /* 0x6D4 */ public float InteractionScanRange;
        /* 0x6D8 */ public float InteractionButtonRange;
        /* 0x6DC */ public float InteractionFocusTime;
        /* 0x6E0 */ public float InteractionSubstanceRange;
        /* 0x6E4 */ public float HeatShieldTime;
        /* 0x6E8 */ public float LaserShakeMin;
        /* 0x6EC */ public float LaserShakeMax;
        /* 0x6F0 */ public float GunRecoil;
        /* 0x6F4 */ public float LaserRecoil;
        /* 0x6F8 */ public float BeamRecoil;
        /* 0x6FC */ public float GrenadeRecoil;
        /* 0x700 */ public float GunRecoilSpring;
        /* 0x704 */ public float BlastRecoilSpring;
        /* 0x708 */ public float RailRecoilSpring;
        /* 0x70C */ public float PulseRecoilSpring;
        /* 0x710 */ public float GunRecoilSettleSpring;
        /* 0x714 */ public float ThirdPersonRecoilMultiplier;
        /* 0x718 */ public float GunRecoilMin;
        /* 0x71C */ public float GunRecoilMax;
        /* 0x720 */ public float ProjectileDamageFalloff;
        /* 0x724 */ public float ShotgunDispersion;
        /* 0x728 */ public GcResourceCollectEffect TerrainResourceCollect;
        /* 0x75C */ public GcResourceCollectEffect TerrainResourceMiniCollect;
        /* 0x790 */ public GcResourceCollectEffect TerrainResourceMeleeCollect;
        /* 0x7C4 */ public GcResourceCollectEffect CrystalResourceCollect;
        /* 0x7F8 */ public GcResourceCollectEffect ShardResourceCollect;
        /* 0x82C */ public GcBoidData MissileSwarm;
        /* 0x858 */ public GcPlayerStickData StickData;
        /* 0x874 */ public bool AutoAim;
        /* 0x878 */ public float AutoAimMaxAccelFactor;
        /* 0x87C */ public float AutoAimFixedInterceptSpeed;
        /* 0x880 */ public float AutoAimTimeOut;
        /* 0x884 */ public float AutoAimMaxAngle;
        /* 0x888 */ public float AutoAimMinScreenDistance;
        /* 0x88C */ public float AutoAimRadiusExtra;
        /* 0x890 */ public float AutoAimStickyMin;
        /* 0x894 */ public float AutoAimStickyMax;
        /* 0x898 */ public TkCurveType AutoAimDotCurve;
        /* 0x89C */ public TkCurveType AutoAimCentreOffsetCurve;
        /* 0x8A0 */ public float AimDistanceShip;
        /* 0x8A4 */ public float AimSpeed;
        /* 0x8A8 */ public float AimWeightAdd;
        /* 0x8AC */ public float AimMinWeight;
        /* 0x8B0 */ public float AimDecay;
        /* 0x8B4 */ public float AimOffset;
        /* 0x8B8 */ public float AimShootableTargetAngle;
        /* 0x8BC */ public float AimDisperseTime;
        /* 0x8C0 */ public float AimDisperseMinTime;
        /* 0x8C4 */ public float AimDisperseCooldownTime;
        /* 0x8C8 */ public float AimDisperseCooldownFactor;
        /* 0x8CC */ public TkCurveType AimDisperseCurve;
        /* 0x8D0 */ public float CrosshairTime;
        /* 0x8D4 */ public float BeaconActivateRange;
        /* 0x8D8 */ public float ExperiencePirateFreighterAttackRange;
        /* 0x8DC */ public float ExperienceWalkerSize;
        /* 0x8E0 */ public float ExperienceInterestingShipDistance;
        /* 0x8E4 */ public float ExperienceInterestingFreighterDistance;
        /* 0x8E8 */ public float ExperienceInterestingDroneDistance;
        /* 0x8EC */ public float ExperienceShipTimeMin;
        /* 0x8F0 */ public float ExperienceShipTimeMax;
        /* 0x8F4 */ public int ExperiencePirateCloseAttackPercentage;
        /* 0x8F8 */ public float ExperiencePirateTimeMin;
        /* 0x8FC */ public float ExperiencePirateTimeMax;
        /* 0x900 */ public float ExperienceDroneTimeMin;
        /* 0x904 */ public float ExperienceDroneTimeMax;
        /* 0x908 */ public float ExperienceFlybyScareRadius;
        /* 0x90C */ public float ExperienceFlybyScareTime;
        /* 0x910 */ public Vector2f ExperienceFlybyStartAngle;
        /* 0x918 */ public float ExperienceAlertRange;
        /* 0x91C */ public float ExperienceAlertSightRange;
        /* 0x920 */ public float ExperienceAlertSightAngle;
        /* 0x924 */ public float ExperienceDroneSpawnOffset;
        /* 0x928 */ public float ExperienceDroneSpawnAngle;
        /* 0x92C */ public float ExperienceMessageBroadcastNearbyDistance;
        /* 0x930 */ public float WantedEnemyAttackAmount;
        [NMS(Size = 0x80)]
        /* 0x934 */ public string Gun;
        /* 0x9B4 */ public float StickDeadZoneMin;
        /* 0x9B8 */ public float StickDeadZoneMax;
        /* 0x9BC */ public TkCurveType StickCurve;
        /* 0x9C0 */ public float AutoLandRange;
        /* 0x9C4 */ public float AutoLandTime;
        /* 0x9C8 */ public float LabelSpringTime;
        /* 0x9CC */ public float LabelOffset;
        /* 0x9D0 */ public float AtmosphereEffectTime;
        /* 0x9D4 */ public float AtmosphereEffectOffset;
        [NMS(Size = 0x7)]
        /* 0x9D8 */ public GcCreatureAlertData[] AlertTable;
        /* 0xA80 */ public float PainFlickerAmount;
        /* 0xA84 */ public float PainColourSeperateAmount;
        /* 0xA88 */ public float PainTime;
        /* 0xA8C */ public GcProjectileLineData PlayerBullet;
        /* 0xAB4 */ public GcProjectileLineData RobotBullet;
        /* 0xADC */ public GcProjectileLineData ShipBullet;
        /* 0xB04 */ public float ExplodeShakeMaxDist;
        /* 0xB08 */ public float ExplodeShakeMaxDistSpace;
        /* 0xB0C */ public float ExplodeShakeStrength;
        /* 0xB10 */ public float FlashSize;
        /* 0xB14 */ public float FlashPosX;
        /* 0xB18 */ public float FlashPosY;
        /* 0xB1C */ public float FlashPosZ;
        /* 0xB20 */ public float FlashSpeed;
        /* 0xB24 */ public float FlashPulse;
        /* 0xB28 */ public float FlashGrow;
        /* 0xB2C */ public float GunRightOffset;
        /* 0xB30 */ public float GunUpOffset;
        /* 0xB34 */ public float LaserBeamMineRate;
        /* 0xB38 */ public float LaserBeamCore;
        /* 0xB3C */ public float LaserBeamFlickerAmp;
        /* 0xB40 */ public float LaserBeamFlickerFreq;
        /* 0xB44 */ public float LaserEndOffset;
        /* 0xB48 */ public float GrenadeTerrainDeformRadius;
        /* 0xB4C */ public float LaserBeamTerrainDeformRadius;
        /* 0xB50 */ public float LaserBeamTerrainDeformVariance;
        /* 0xB54 */ public float LaserBeamOverheatTime;
        /* 0xB58 */ public float LaserBeamAmmoUseTime;
        /* 0xB5C */ public float ReloadButtonHoldTimeToHolster;
        /* 0xB60 */ public float WeaponChangeModeTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xB64 */ public byte[] PaddingB64;
        /* 0xB70 */ public Vector4f WeaponBarrelOffset;
        /* 0xB80 */ public float WeaponLowerDelay;
        /* 0xB84 */ public float WeaponHolsterDelay;
        /* 0xB88 */ public float WeaponLag;
        /* 0xB8C */ public float WeaponBobFactorWalkDeadZone;
        /* 0xB90 */ public float WeaponBobFactorWalk;
        /* 0xB94 */ public float WeaponBobFactorRun;
        /* 0xB98 */ public float WeaponBobBlendTime;
        /* 0xB9C */ public TkCurveType WeaponBobBlendCurve;
        /* 0xBA0 */ public float WeaponGrenadeTime;
        /* 0xBA4 */ public float WeaponGunTime;
        /* 0xBA8 */ public float WeaponRailFireTime;
        /* 0xBAC */ public float WeaponRailRechargeTime;
        /* 0xBB0 */ public int MaxBuildHeight;
        /* 0xBB4 */ public float SpaceMaxGravityDist;
        /* 0xBB8 */ public float SpaceMinGravityDist;
        /* 0xBBC */ public float UnderwaterImpact;
        /* 0xBC0 */ public float UnderwaterMaxSpeed;
        /* 0xBC4 */ public float UnderwaterForce;
        /* 0xBC8 */ public float UnderwaterBrake;
        /* 0xBCC */ public float UnderwaterFloat;
        /* 0xBD0 */ public float UnderwaterFloatForce;
        /* 0xBD4 */ public float UnderwaterFloatRange;
        /* 0xBD8 */ public float UnderwaterFloatFreq;
        /* 0xBDC */ public float BulletBend;
        /* 0xBE0 */ public float ShootSizeMinZ;
        /* 0xBE4 */ public float ShootSizeMaxZ;
        /* 0xBE8 */ public float ShootSizeMinXY;
        /* 0xBEC */ public float ShootSizeMaxXY;
        /* 0xBF0 */ public float ShootSizeTime;
        /* 0xBF4 */ public float ShootSizeBase;
        /* 0xBF8 */ public float ShootOffset;
        /* 0xBFC */ public float ShootPrepTime;
        /* 0xC00 */ public float GrenadeCarveRadius;
        /* 0xC04 */ public float ChargeTime;
        /* 0xC08 */ public float EnergyBallSpeed;
        /* 0xC0C */ public float ChargedEnergyBallSpeed;
        /* 0xC10 */ public float LookRayRadius;
        /* 0xC14 */ public float PickRange;
        /* 0xC18 */ public float DamageRateWhenUnderNoGravity;
        /* 0xC1C */ public float TakeDamageImpulse;
        /* 0xC20 */ public float HardLandTime;
        /* 0xC24 */ public float HardLandMin;
        /* 0xC28 */ public float HardLandMax;
        /* 0xC2C */ public float MeleeRange;
        /* 0xC30 */ public float MeleeTime;
        /* 0xC34 */ public float MeleeForcePush;
        /* 0xC38 */ public float MeleeOffset;
        /* 0xC3C */ public float PushForceAirFactor;
        /* 0xC40 */ public int HUDHeightPosX;
        /* 0xC44 */ public int HUDHeightPosY;
        /* 0xC48 */ public float TargetDistance;
        /* 0xC4C */ public float TargetRadius;
        /* 0xC50 */ public float HoldForce;
        /* 0xC54 */ public float HoldTime;
        /* 0xC58 */ public float HoldActionDistX;
        /* 0xC5C */ public float HoldActionDistY;
        /* 0xC60 */ public float HoldActionDistZ;
        /* 0xC64 */ public float HoldDistX;
        /* 0xC68 */ public float HoldDistY;
        /* 0xC6C */ public float HoldDistZ;
        /* 0xC70 */ public float HoldMaxForce;
        /* 0xC74 */ public float HoldRotate;
        /* 0xC78 */ public float BalanceStrength;
        /* 0xC7C */ public float BalanceSpeed;
        /* 0xC80 */ public float GroundWalkForce;
        /* 0xC84 */ public float GroundWalkBrake;
        /* 0xC88 */ public float GroundWalkBrakeWhileMoving;
        /* 0xC8C */ public float GroundWalkSpeed;
        /* 0xC90 */ public float GroundRunSpeed;
        /* 0xC94 */ public float GroundWalkRecoverySpeedDamper;
        /* 0xC98 */ public float ExertionSmoothTime;
        /* 0xC9C */ public float ExertionFromPainTime;
        /* 0xCA0 */ public float AnimWalkSpeed;
        /* 0xCA4 */ public float AnimRunSpeed;
        /* 0xCA8 */ public float AnimWalkToRunSpeed;
        /* 0xCAC */ public float AnimWalkBlendPoint;
        /* 0xCB0 */ public float AnimRunBlendPoint;
        /* 0xCB4 */ public float MaxSlopeAngle;
        /* 0xCB8 */ public float SlopeSlidingSpeed;
        /* 0xCBC */ public float SlopeSlideBrake;
        /* 0xCC0 */ public float MinSlideTime;
        /* 0xCC4 */ public float MaxWalkableSlopeAngle;
        /* 0xCC8 */ public float MinSpidermanSlopeAngle;
        /* 0xCCC */ public float MinTimeToHoldSpidermanPose;
        /* 0xCD0 */ public float MaxSpidermanSlopeAngle;
        /* 0xCD4 */ public float MaxClingableSlopeAngle;
        /* 0xCD8 */ public float MinimumPushOffForceToSlide;
        /* 0xCDC */ public float FullClipReloadSpeedMultiplier;
        /* 0xCE0 */ public float ReloadTapButtonSpeedIncrease;
        /* 0xCE4 */ public float ClingBrakeMultiplier;
        /* 0xCE8 */ public float ClingAngleThreshold;
        /* 0xCEC */ public float ClingSpeedThreshold;
        /* 0xCF0 */ public float ClimbableStickinessAngle;
        /* 0xCF4 */ public float MinUpAmount;
        /* 0xCF8 */ public float FootOffset;
        /* 0xCFC */ public float MaxFallSpeed;
        /* 0xD00 */ public float PushForceDecay;
        /* 0xD04 */ public float LeanFwdMaxAngle;
        /* 0xD08 */ public float LeanBackMaxAngle;
        /* 0xD0C */ public float LeanLeftMaxAngle;
        /* 0xD10 */ public float LeanRightMaxAngle;
        /* 0xD14 */ public float LeanAmount;
        /* 0xD18 */ public float LeanAmountFwd;
        /* 0xD1C */ public float HelmetLag;
        /* 0xD20 */ public float HelmetMaxLag;
        /* 0xD24 */ public float HelmetBob;
        /* 0xD28 */ public float JetpackHelmetBob;
        /* 0xD2C */ public float ShipCameraLag;
        /* 0xD30 */ public float MaxResource;
        /* 0xD34 */ public float ShieldRestoreSpeed;
        /* 0xD38 */ public float ShieldRestoreDelay;
        /* 0xD3C */ public float TimeHoldDownAccelerateToLaunchFromOutpost;
        /* 0xD40 */ public float DeathScreenFadeInThirdPerson;
        /* 0xD44 */ public float DeathScreenFadeInUnderwaterThirdPerson;
        /* 0xD48 */ public float DeathScreenFadeInTime;
        /* 0xD4C */ public float DeathScreenShipFadeInTime;
        /* 0xD50 */ public float DeathScreenPauseTime;
        /* 0xD54 */ public float DeathScreenMaxRegenWaitTime;
        /* 0xD58 */ public float DeathScreenMinRegenWaitTime;
        /* 0xD5C */ public float DeathScreenFadeOutTime;
        /* 0xD60 */ public GcPlayerStickData LookStickData;
        /* 0xD7C */ public GcPlayerStickData AmbientModeLookStickData;
        /* 0xD98 */ public int LowHealthEffectPips;
        /* 0xD9C */ public int LowHealthEffectShield;
        /* 0xDA0 */ public float CriticalHitTime;
        /* 0xDA4 */ public float CriticalHitDesatTime;
        /* 0xDA8 */ public float CriticalHitDesatFreq;
        [NMS(Size = 0x2)]
        /* 0xDAC */ public GcCameraSpawnSetupData[] FirstSpawnDataTable;
        /* 0xDCC */ public GcInventoryValueData ShipValueData;
        /* 0xDE8 */ public GcInventoryValueData WeaponValueData;
        /* 0xE04 */ public GcInventoryValueData FreighterValueData;
        [NMS(Size = 0x7)]
        /* 0xE20 */ public float[] TechRarityData;
        [NMS(Size = 0x6)]
        /* 0xE3C */ public float[] TechLearningProbabilities;
        /* 0xE54 */ public int NumTechShopSlots;
        /* 0xE58 */ public float GrassPushDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xE5C */ public byte[] PaddingD1c;
        /* 0xE60 */ public GcCameraAnomalySetupData AnomalyBlachHoleSpawnData;
        /* 0xEA0 */ public GcCameraAnomalySetupData AnomalyAtlasStationSpawnData;
        /* 0xEE0 */ public GcCameraAnomalySetupData AnomalyMiniStationSpawnData;
        /* 0xF20 */ public GcJourneyMedalTiers MedalTiers;
        /* 0xF30 */ public int LowGuildRank;
        /* 0xF34 */ public int MedGuildRank;
        /* 0xF38 */ public int HighGuildRank;
        /* 0xF3C */ public int BestGuildRank;
        /* 0xF40 */ public float LaserWeaponRange;
        /* 0xF44 */ public float LaserShipRange;
        /* 0xF48 */ public float TerrainLaserRange;
        /* 0xF4C */ public float VehicleLaserRange;
        /* 0xF50 */ public GcPlayerCommunicatorMessage PirateHailMessage;
        /* 0xFA0 */ public GcShipDialogue TraderHailMessages;
        [NMS(Size =  0x4)]
        /* 0x1208 */ public int[] TraderHailReceiveRegular;
        [NMS(Size = 0x2)]
        /* 0x1218 */ public int[] TraderHailReceiveFight;
        [NMS(Size =  0x4)]
        /* 0x1220 */ public int[] TraderHailSend;
    }
}