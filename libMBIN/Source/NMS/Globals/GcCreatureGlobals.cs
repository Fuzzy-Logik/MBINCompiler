using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals {

    [NMS( GUID = 0xF239EC0A912FB902 )]
    public class GcCreatureGlobals : GlobalData {

        /* 0x0 */ public bool IsHurtingCreaturesACrime;
        /* 0x4 */ public float CreatureSeed;
        /* 0x8 */ public int MaxEcosystemCreatures;
        /* 0xC */ public bool UncapSpawningforVideo;
        /* 0xD */ public bool AllowSpawningOnscreen;
        /* 0x10 */ public float ResourceSpawnTime;
        /* 0x14 */ public float TurnInPlaceIdleTime;
        /* 0x18 */ public float TurnInPlaceMaxAngle;
        /* 0x1C */ public float TurnInPlaceMinTime;
        /* 0x20 */ public float TurnInPlaceMaxSpeed;
        /* 0x24 */ public float SceneTerrainSpawnMinDistance;
        /* 0x28 */ public float CreatureMinAlignSpeed;
        /* 0x2C */ public float PatrolMinDist;
        /* 0x30 */ public float PatrolMaxDist;
        /* 0x34 */ public float PatrolHeightOffset;
        /* 0x38 */ public float PatrolGradientFactor;
        /* 0x3C */ public float CreatureWaryTime;
        /* 0x40 */ public float CreatureMinRunTime;
        /* 0x44 */ public float CreatureHearingRange;
        /* 0x48 */ public float CreatureSightRange;
        /* 0x4C */ public float CreatureMoveIdle;
        /* 0x50 */ public float CreatureTurnMin;
        /* 0x54 */ public float CreatureTurnMax;
        /* 0x58 */ public float CreatureBrakeForce;
        /* 0x5C */ public float CreatureMinAnimMoveSpeed;
        /* 0x60 */ public float CreatureLookBeforeGoingTime;
        /* 0x64 */ public float CreatureLookBeforeFleeingTime;
        /* 0x68 */ public float CreatureLookBeforeFleeingIfShotTime;
        /* 0x6C */ public float CreatureLookScaryThingTime;
        /* 0x70 */ public float CreatureLookPlayerForceLookTime;
        /* 0x74 */ public float FootPlantError;
        /* 0x78 */ public float RecoverHealthTime;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x7C */ public byte[] Padding7C;

        /* 0x80 */ public GcCameraShakeData PainShake;
        /* 0x140 */ public float PatrolSwitchMinTime;
        /* 0x144 */ public float ExtraFollowStrength;
        /* 0x148 */ public float ExtraFollowFreq1;
        /* 0x14C */ public float ExtraFollowFreq2;
        /* 0x150 */ public float GiantSnakeEmergeHeight;
        /* 0x154 */ public float GiantSnakeEmergeDeep;
        /* 0x158 */ public float GiantSnakeEmergeTime;
        /* 0x15C */ public float GiantSnakeEmergeWide;
        /* 0x160 */ public float GiantSnakeEmergeUnderTime;
        /* 0x164 */ public float GiantSnakeEmergeOffset;
        /* 0x168 */ public float GiantSnakeRadius;
        /* 0x16C */ public float GiantSnakeHeadOffset;
        /* 0x170 */ public float ShieldFadeTime;
        /* 0x174 */ public float SharkAlongPathSpeed;
        /* 0x178 */ public float SwarmBrakingForce;
        /* 0x17C */ public float SharkToPathYDamp;
        /* 0x180 */ public float SharkAttackSpeed;
        /* 0x184 */ public float SharkAttackAccel;
        /* 0x188 */ public float SharkPatrolSpeed;
        /* 0x18C */ public float SharkPatrolRadius;
        /* 0x190 */ public float SharkPatrolEnd;
        /* 0x194 */ public float SharkGetToPathSpeed;
        /* 0x198 */ public float SharkAlignSpeed;
        /* 0x19C */ public float FishBobFrequency;
        /* 0x1A0 */ public float FishBobAmplitude;
        /* 0x1A4 */ public float InfluenceRadius;
        /* 0x1A8 */ public float InfluenceForce;
        /* 0x1AC */ public float InfluenceThreshold;
        /* 0x1B0 */ public float InfluenceDeflect;
        /* 0x1B4 */ public float TargetSearchTimeout;
        /* 0x1B8 */ public float AttractMinDistance;
        /* 0x1BC */ public float SwarmMoveYFactor;
        /* 0x1C0 */ public float DroneExplodeRadius;
        /* 0x1C4 */ public float WeaponRepelRange;
        /* 0x1C8 */ public float WeaponRepelAmount;
        /* 0x1CC */ public float VelocityAlignStrength;
        /* 0x1D0 */ public float VelocityAlignSpeed;
        /* 0x1D4 */ public float HeightLookAhead;
        /* 0x1D8 */ public float MaxHeightTime;
        /* 0x1DC */ public float PlayerBirdDistance;
        /* 0x1E0 */ public float FishSpeedMin;
        /* 0x1E4 */ public float FishSpeedMax;
        /* 0x1E8 */ public float FishSwimMaxAcceleration;
        /* 0x1EC */ public float AlertDistance;
        /* 0x1F0 */ public float RepelRange;
        /* 0x1F4 */ public float RepelAmount;
        /* 0x1F8 */ public float FishTurn;
        /* 0x1FC */ public float TargetReachedDistance;
        /* 0x200 */ public float MaxSpeed;
        /* 0x204 */ public float MaxForce;
        /* 0x208 */ public float MaxTorque;
        /* 0x20C */ public float MinWaterSpawnDepth;
        /* 0x210 */ public float WaterSpawnOffset;
        /* 0x214 */ public float SpawnDistanceModifierForUnderwater;
        /* 0x218 */ public float FootDustGroundTintStrength;
        /* 0x21C */ public GcFlyingSnakeData FlyingSnakeData;
        [NMS(Size = 0x3)]
        /* 0x25C */ public GcCreatureAlertData[] AlertTable;
        /* 0x2A4 */ public bool ShowScale;
        /* 0x2A8 */ public float CreatureMedMinSize;
        /* 0x2AC */ public float CreatureLargeMinSize;
        /* 0x2B0 */ public float CreatureHugeMinSize;
        /* 0x2B4 */ public int CreatureSmallHealth;
        /* 0x2B8 */ public int CreatureMedHealth;
        /* 0x2BC */ public int CreatureLargeHealth;
        /* 0x2C0 */ public int CreatureHugeHealth;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C4 */ public byte[] Padding2C4;

        [NMS(Size = 0x10)]
        /* 0x2C8 */ public string CreatureLargeWalkShake;
        /* 0x2D8 */ public float CreatureLargeWalkMaxShakeDist;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2DC */ public byte[] Padding2DC;

        [NMS(Size = 0x10)]
        /* 0x2E0 */ public string CreatureLargeRunShake;
        /* 0x2F0 */ public float CreatureLargeRunMaxShakeDist;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2F4 */ public byte[] Padding2F4;

        [NMS(Size = 0x10)]
        /* 0x2F8 */ public string CreatureHugeWalkShake;
        /* 0x308 */ public float CreatureHugeWalkMaxShakeDist;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x30C */ public byte[] Padding30C;

        [NMS(Size = 0x10)]
        /* 0x310 */ public string CreatureHugeRunShake;
		/* 0x320 */ public float CreatureHugeRunMaxShakeDist;

		/* 0x324 */ public float SmallCreaturePerceptionDistance;
		/* 0x328 */ public float largeCreaturePerceptionDistance;
		/* 0x32C */ public float SmallCreatureFleePlayerDistance;
		/* 0x330 */ public float LargeCreatureFleePlayerDistance;
		/* 0x334 */ public float SmallCreatureAvoidPlayerDistance;
		/* 0x338 */ public float LargeCreatureAvoidPlayerDistance;
		/* 0x33C */ public float PredatorPerceptionDistance;
		/* 0x340 */ public float PassiveFleePlayerDistance;
		/* 0x344 */ public float AdultBabyKilledNoticeDistance;
		/* 0x348 */ public float PercentagePlayerPredators;
		/* 0x34C */ public int PredatorSmallHealth;
		/* 0x350 */ public int PredatorMedHealth;
		/* 0x354 */ public int PredatorLargeHealth;
		/* 0x358 */ public int PredatorHugeHealth;
		/* 0x35C */ public int PlayerPredatorHealth;
		/* 0x360 */ public float PredatorApproachTime;
		/* 0x364 */ public float PredatorNoticePauseTime;
		/* 0x368 */ public float PredatorStealthDist;
		/* 0x36C */ public float PredatorChargeDist;
		/* 0x370 */ public float PredatorChargeDistScale;
		/* 0x374 */ public float FishPredatorChargeDist;
		/* 0x378 */ public float FishPredatorChargeDistScale;
		/* 0x37C */ public float PredatorBoredomDistance;
		/* 0x380 */ public float PlayerPredatorBoredomDistance;
		/* 0x384 */ public float PredatorRegainInterestTime;
		/* 0x388 */ public float PlayerPredatorRegainInterestTime;
		/* 0x38C */ public float PredatorRunAwayDist;
		/* 0x390 */ public float PredatorRoarProbAfterHit;
		/* 0x394 */ public float PredatorRoarProbAfterMiss;
		/* 0x398 */ public float PredatorRunAwayHealthPercent;
		/* 0x39C */ public bool FiendsCanAttack;
		/* 0x3A0 */ public int FiendHealth;
		/* 0x3A4 */ public float FiendPerceptionDistance;
		/* 0x3A8 */ public float FiendSpawnDistance;
		/* 0x3AC */ public float FiendDespawnDistance;
		/* 0x3B0 */ public float FiendReplicateStartDistance;
		/* 0x3B4 */ public float FiendReplicateEndDistance;
		/* 0x3B8 */ public float FiendAggroTime;
		/* 0x3BC */ public int FiendMaxEngaged;
		/* 0x3C0 */ public int FiendMaxAttackers;
		/* 0x3C4 */ public float DelayBetweenPounceAttacks;
		/* 0x3C8 */ public float DelayBetweenSpitAttacks;
		/* 0x3CC */ public float FiendMaxVerticalForPounce;

		/* 0x3D0 */ public float FiendZigZagSpeed;
		/* 0x3D4 */ public float FiendZigZagStrength;
		/* 0x3D8 */ public int FiendEggsToUnlockSpit;
		/* 0x3DC */ public int MaxFiendsToSpawn;
		/* 0x3E0 */ public float FiendMinSpawnTime;
		/* 0x3E4 */ public float FiendMaxSpawnTime;
		/* 0x3E8 */ public float FiendAggroIncreaseDamageEgg;
		/* 0x3EC */ public float FiendAggroIncreaseDestroyEgg;
		/* 0x3F0 */ public float FiendAggroDecreasePerSpawn;
		/* 0x3F4 */ public float FiendCritAreaSize;
		/* 0x3F8 */ public float RoutineSpeed;
		/* 0x3FC */ public float RoutineOffset;
		/* 0x400 */ public float RagdollTau;
		/* 0x404 */ public float RagdollDamping;
		/* 0x408 */ public float RagdollConeLimit;
		/* 0x40C */ public float RagdollTwistLimit;
		/* 0x410 */ public float RagdollMotorFadeStart;
		/* 0x414 */ public float RagdollMotorFadeEnd;
		/* 0x418 */ public int MaxRagdollsBeforeDespawnOffscreen;
		/* 0x41C */ public int MaxRagdollsBeforeDespawnOnscreen;
		/* 0x420 */ public float TurnRadiusMultiplier;
		/* 0x424 */ public float TurnSlowAreaCos;
		/* 0x428 */ public float BadTurnPercent;
		/* 0x42C */ public float BadTurnWeight;
		/* 0x430 */ public float MinScaleForNavMap;
		/* 0x434 */ public float ImpassabilityBrakeTime;
		/* 0x438 */ public float ImpassabilityUnbrakeTime;
		/* 0x43C */ public float ImpassabilityTurnSpeedMultiplier;
		/* 0x440 */ public float NavMapLookAhead;
		/* 0x444 */ public float VelocityAlignYFactorMin;
		/* 0x448 */ public float VelocityAlignYFactorMax;
		/* 0x44C */ public float BrakingForce;
		/* 0x450 */ public float BrakingForceY;
		/* 0x454 */ public float FlowFieldWeight;
		/* 0x458 */ public float FollowWeight;
		/* 0x45C */ public float AvoidCreaturesWeight;
		/* 0x460 */ public float AvoidImpassableWeight;
		/* 0x464 */ public float FollowLeaderAlignWeight;
		/* 0x468 */ public float FollowLeaderCohereWeight;
		/* 0x46C */ public float DefaultWalkMoveSpeed;
		/* 0x470 */ public float DefaultTrotMoveSpeed;
		/* 0x474 */ public float DefaultRunMoveSpeed;
		/* 0x478 */ public float PredatorWalkMoveSpeed;
		/* 0x47C */ public float PredatorTrotMoveSpeed;
		/* 0x480 */ public float PredatorRunMoveSpeed;
		/* 0x484 */ public float HeightDiffPenalty;
		/* 0x488 */ public float EdgeClosenessPenalty;
		/* 0x48C */ public float PelvisIkStrength;
		/* 0x490 */ public float SteeringUpdateRate;
		/* 0x494 */ public float PathOverestimate;
		/* 0x498 */ public float FishWaterSurfaceAnticipate;
		/* 0x49C */ public float FishWaterSurfaceAvoidStrength;
		/* 0x4A0 */ public float FishDesiredDepth;
		/* 0x4A4 */ public float FishMinHeightAboveSeaBed;
		/* 0x4A8 */ public float FishSeaBedAvoidStrength;
		/* 0x4AC */ public float AttackPlayerDistance;
		/* 0x4B0 */ public float SpawnCameraAngleCos;
		/* 0x4B4 */ public float SpawnMinDistPercentage;
		/* 0x4B8 */ public float SpawnOnscreenDist;
		/* 0x4BC */ public float FadeScaleMultiplier;
		/* 0x4C0 */ public float FadeScalePower;
		/* 0x4C4 */ public float FadeDistance;
		/* 0x4C8 */ public float MinFade;
		/* 0x4CC */ public float MaxFade;
		/* 0x4D0 */ public bool ProcessPendingSpawnRequests;
		/* 0x4D4 */ public float SpawnsAvoidBaseMultiplier;
		/* 0x4D8 */ public int PerceptionUpdateRate;
		/* 0x4DC */ public bool AllowSleeping;
		/* 0x4DD */ public bool DebugDrawTrails;
		/* 0x4E0 */ public float TrailHalfLife;
		/* 0x4E4 */ public bool EnableTrailIk;
		/* 0x4E8 */ public float DetailAnimBlendInTime;
		/* 0x4EC */ public float DetailAnimBlendOutTime;
		/* 0x4F0 */ public float DetailAnimMinPauseTime;
		/* 0x4F4 */ public float DetailAnimMaxPauseTime;
		/* 0x4F8 */ public bool DetailAnimPlayWhileWalking;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x4F9 */ public byte[] Padding4F9;

        [NMS(Size = 0x10)]
        /* 0x500 */ public string CreatureDeathEffectSmall;
		[NMS(Size = 0x10)]
		/* 0x510 */ public string CreatureDeathEffectMedium;
		[NMS(Size = 0x10)]
		/* 0x520 */ public string CreatureDeathEffectBig;

		/* 0x530 */ public float FootParticleTime;
        /* 0x534 */ public bool PiedPiper;
        /* 0x538 */ public float FollowPlayerDistance;
        /* 0x53C */ public float FollowRunPlayerDistance;
        /* 0x540 */ public float FollowRange;
        /* 0x544 */ public float SearchItemDistance;
        /* 0x548 */ public float SearchItemFrequency;
        /* 0x54C */ public float SearchItemGiveUpDistance;
        /* 0x550 */ public float SearchItemGiveUpTime;
        /* 0x554 */ public float SearchItemNotifyTime;
        /* 0x558 */ public float SearchSpawnRandomItemProbability;
        /* 0x55C */ public float MiningRandomProbability;
        /* 0x560 */ public bool DebugSearch;
        /* 0x564 */ public int FriendlyCreatureLimit;
        /* 0x568 */ public int FeedingTaskAmount;
        /* 0x56C */ public float FeedingFollowTime;
        /* 0x570 */ public float FeedingNoticeTime;
        /* 0x574 */ public float FeedingNoticeDistance;
        /* 0x578 */ public float AnimChangeCoolDown;
        /* 0x57C */ public float GroupRunProbability;
        /* 0x580 */ public float GroupBabyRunProbability;
        /* 0x584 */ public float GroupRunStormProbability;
        /* 0x588 */ public float GroupLookAtProbability;
        /* 0x58C */ public float GroupLookAtDurationMin;
        /* 0x590 */ public float GroupLookAtDurationMax;
        /* 0x594 */ public float GroupRunDurationMin;
        /* 0x598 */ public float GroupRunDurationMax;
        /* 0x59C */ public float GroupFemaleProportion;
        /* 0x5A0 */ public float GroupBabyProportion;
        /* 0x5A4 */ public float GroupBabyScale;
        /* 0x5A8 */ public float GroupBabyHealthMultiplier;
        /* 0x5AC */ public float MaxBirdsProportion;
        /* 0x5B0 */ public float HerdGroupSizeMultiplier;
        /* 0x5B4 */ public bool DrawRoutineFollowDebug;
        /* 0x5B8 */ public float AdultCorrelationValue;
        /* 0x5BC */ public float GrassPushRadius;
        /* 0x5C0 */ public float GrassPushStrength;
        /* 0x5C4 */ public float GrassPushMaxSize;
        /* 0x5C8 */ public bool DrawGrassPushRadius;
        [NMS(Size = 0x80)]
        /* 0x5C9 */ public string DefaultCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x649 */ public string DefaultAirCreatureSettings;
        [NMS(Size = 0x80)]
        /* 0x6C9 */ public string DefaultWaterCreatureSettings;
        /* 0x74C */ public float CreatureSpeedMultiplier;
        /* 0x750 */ public float PredatorSpeedMultiplier;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x754 */ public byte[] Padding754;

        [NMS(Size = 0x3)]
        /* 0x758 */ public NMSString0x10[] FeedingSubstances;
        [NMS(Size = 0x3)]
        /* 0x788 */ public NMSString0x10[] KillingSubstances;
        [NMS(Size = 0x3)]
        /* 0x7B8 */ public NMSString0x10[] LootItems;

        /* 0x7E8 */ public int PauseBetweenCreatureSpawnRequests;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x7EC */ public byte[] EndPadding;

    }

}