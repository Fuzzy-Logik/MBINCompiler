﻿using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals {

    [NMS( GUID = 0x3276D67F7EC472E5 )]
    public class GcCharacterGlobals : GlobalDataType {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string CharacterFile;
        /* 0x080 */ public GcSeed CharacterSeedOverride;
		/* 0x90 */ public float DontShowCharacterWithinCameraDistance;
		/* 0x94 */ public float CharacterTurnSpeed;
		/* 0x98 */ public float CharacterJetpackTurnSpeed;
		/* 0x9C */ public float CharacterJetpackTurnAimSpeed;
		/* 0xA0 */ public float CharacterTurnAimSpeed;
		/* 0xA4 */ public float CharacterSwimmingTurnSpeed;
		/* 0xA8 */ public float CharacterSwimmingTurnAimSpeed;
		/* 0xAC */ public float RocketBootsLandedTurnSpeed;
		/* 0xB0 */ public float RocketBootsTurnSpeed;
		/* 0xB4 */ public float FeetShiftOnTurnSpeed;
		/* 0xB8 */ public float FeetShiftOnTurnMaxSpeed;
		/* 0xBC */ public float MinTurnAngle;
		/* 0xC0 */ public float YawPullSpeed;
		/* 0xC4 */ public float GunRotationSpeed;
		/* 0xC8 */ public float AimPitchAnimScale;
		/* 0xCC */ public float AimYawAnimScale;
		/* 0xD0 */ public float AimPitchInterpSpeed;
		/* 0xD4 */ public float MinSwimmingPitchRotation;
		/* 0xD8 */ public float MaxSwimmingPitchRotation;
		/* 0xDC */ public float MinSwimmingRollRotation;
		/* 0xE0 */ public float MaxSwimmingRollRotation;
		/* 0xE4 */ public float SwimmingSmoothTime;
		/* 0xE8 */ public float SwimmingSmoothTimeWithWeapon;
		/* 0xEC */ public float SwimmingRollSmoothTime;
		/* 0xF0 */ public float SwimmingRollSmoothTimeWithWeapon;
		/* 0xF4 */ public float LadderDistanceToAutoMount;
		/* 0xF8 */ public float LadderCooldownAfterBeforeAutoClimb;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0xFC */ public byte[] PaddingFC;

        [NMS(Size = 0x10)]
        /* 0x100 */ public string LadderClimbIdle;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string LadderClimbUp;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string LadderClimbDown;
        [NMS(Size = 0x10)]
        /* 0x130 */ public string LadderMountBottom;
        [NMS(Size = 0x10)]
        /* 0x140 */ public string LadderDismountBottom;
        [NMS(Size = 0x10)]
        /* 0x1450 */ public string LadderMountTop;
        [NMS(Size = 0x10)]
        /* 0x160 */ public string LadderDismountTop;

		/* 0x170 */ public float SlopeAngleForUphillClimb;
		/* 0x174 */ public float SlopeAngleForDownhillClimb;
		/* 0x178 */ public float SlidingBrake;
		/* 0x17C */ public float SlopeAngleForSlide;
		/* 0x180 */ public float UphillSpeedMultiplier;
		/* 0x184 */ public float TrudgeUphillSpeed;
		/* 0x188 */ public float MaxAnkleRotationAngle;
		/* 0x18C */ public float RotateToFaceSlopeSpeed;
		/* 0x190 */ public float TimeNotOnGroundToBeConsideredInAir;
		/* 0x194 */ public float TimeNotOnGroundToUseFallingCamera;
		/* 0x198 */ public float TimeFallingUntilPanic;
		/* 0x19C */ public float BankingMinimumSpeed;
		/* 0x1A0 */ public float BankingMaxStrength;
		/* 0x1A4 */ public float BankingSpeedForMaxStrength;
		/* 0x1A8 */ public float MinimumIdleToJogAnimSpeed;
		/* 0x1AC */ public float RootedAnimInterpolationTime;
		/* 0x1B0 */ public float IKLegStretchStrength;
		/* 0x1B4 */ public float IkBlendStrengthSpeed;
		/* 0x1B8 */ public float FootPlantedTolerance;
		/* 0x1BC */ public float FootPlantSpring;
		/* 0x1C0 */ public float BlendToNewFeetSpeed;
		/* 0x1C4 */ public float TimeAfterDeathRagdollIsEnabledForward;
		/* 0x1C8 */ public float TimeAfterDeathRagdollIsEnabledBackward;
		/* 0x1CC */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
		/* 0x1D0 */ public float RagdollTau;
		/* 0x1D4 */ public float RagdollDamping;
		/* 0x1D8 */ public float RagdollConeLimit;
		/* 0x1DC */ public float RagdollTwistLimit;
		/* 0x1E0 */ public float RagdollMotorFadeStart;
		/* 0x1E4 */ public float RagdollMotorFadeEnd;
		/* 0x1E8 */ public float MinStickForIntoJogAnim;
		/* 0x1EC */ public float SmoothVelocitySpeed;
		/* 0x1F0 */ public float TimeToShowSplashEffect;
		/* 0x1F4 */ public float UnderwaterToAirTolerance;
		/* 0x1F8 */ public float WaterBottomSmoothPushUp;
		/* 0x1FC */ public float WaterBottomSmoothPushUpDepth;

    }

}
