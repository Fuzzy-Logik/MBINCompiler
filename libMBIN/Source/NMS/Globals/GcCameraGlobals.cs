using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals {

    [NMS( GUID = 0x5E2BB84C26535A58 )]
    public class GcCameraGlobals : GlobalDataType {

		/* 0x0 */ public bool PauseThirdPersonCamInPause;
		/* 0x4 */ public float TogglePerspectiveBlendTime;
		/* 0x8 */ public float ThirdPersonAfterIntroCamBlendTime;
		/* 0xC */ public float ThirdPersonSkipIntroCamBlendTime;
		/* 0x10 */ public float VehicleExitFlashTime;
		/* 0x14 */ public float VehicleExitFlashStrength;
		/* 0x18 */ public float VehicleFirstToThirdExitOffsetY;
		/* 0x1C */ public float VehicleFirstToThirdExitOffsetZ;
		/* 0x20 */ public float ShipThirdPersonBlendTime;
		/* 0x24 */ public float ShipThirdPersonBlendWithOffsetTime;
		/* 0x28 */ public float ShipThirdPersonBlendOffset;
		/* 0x2C */ public float ShipThirdPersonBlendOutTime;
		/* 0x30 */ public float ShipThirdPersonBlendOutOffset;
		/* 0x34 */ public float ShipFirstPersonBlendTime;
		/* 0x38 */ public float ShipFirstPersonBlendOffset;
		/* 0x3C */ public float ShipThirdPersonEnterBlendTime;
		/* 0x40 */ public float ShipThirdPersonEnterBlendOffset;
		/* 0x44 */ public float FlybyMinRange;
		/* 0x48 */ public float FlybyRange;
		/* 0x4C */ public float FlybyMinRelativeSpeed;
		/* 0x50 */ public float FlybyRelativeSpeedRange;
		/* 0x54 */ public float FlybyInVehicleDamper;
		/* 0x58 */ public float BinocularFlashTime;
		/* 0x5C */ public float BinocularFlashStrength;
		/* 0x60 */ public float MinFirstPersonCameraPitch;
		/* 0x64 */ public float MaxFirstPersonCameraPitch;
		/* 0x68 */ public GcCameraFollowSettings CharacterUnarmedCam;
		/* 0x148 */ public GcCameraFollowSettings CharacterRunCam;
		/* 0x228 */ public GcCameraFollowSettings CharacterCombatCam;
		/* 0x308 */ public GcCameraFollowSettings CharacterIndoorCam;
		/* 0x3E8 */ public GcCameraFollowSettings CharacterAirborneCam;
		/* 0x4C8 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
		/* 0x5A8 */ public GcCameraFollowSettings CharacterRocketBootsCam;
		/* 0x688 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
		/* 0x768 */ public GcCameraFollowSettings CharacterFallingCam;
		/* 0x848 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
		/* 0x928 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
		/* 0xA08 */ public GcCameraFollowSettings CharacterUnderwaterCam;
		/* 0xAE8 */ public float ThirdPersonCameraChangeBlendTime;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0xAEC */ public byte[] PaddingAEC;

		/* 0xAF0 */ public GcCameraFollowSettings BuggyFollowCam;
		/* 0xBD0 */ public GcCameraFollowSettings HovercraftFollowCam;
		/* 0xCB0 */ public GcCameraFollowSettings SubmarineFollowCam;
		/* 0xD90 */ public GcCameraFollowSettings BikeFollowCam;
		/* 0xE70 */ public GcCameraFollowSettings WheeledBikeFollowCam;
		/* 0xF50 */ public GcCameraFollowSettings TruckFollowCam;
		/* 0x1030 */ public GcCameraFollowSettings SpaceshipFollowCam;
		/* 0x1110 */ public GcCameraFollowSettings DropshipFollowCam;
		/* 0x11F0 */ public GcCameraFollowSettings ShuttleFollowCam;
		/* 0x12D0 */ public GcCameraFollowSettings RoyalShipFollowCam;
		/* 0x13B0 */ public GcCameraFollowSettings ScienceShipFollowCam;

		/* 0x1490 */ public float FrontendModelCameraSpringTime;
		/* 0x1494 */ public float ModelViewFlashTime;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1498 */ public byte[] Padding1498;
		/* 0x14A0 */ public Vector4f ModelViewOffset;
		/* 0x14B0 */ public Vector2f ModelViewFocusOffset;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x14B8 */ public byte[] Padding14B8;
        /* 0x14C0 */ public Vector4f InteractionOffset;
		/* 0x14D0 */ public Vector4f InteractionShipFocusOffset;

		/* 0x14E0 */ public float DistanceForFleetInteraction;
		/* 0x14E4 */ public float DistanceForFrigateInteraction;
		/* 0x14E8 */ public float DistanceForFrigatePurchaseInteraction;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14EC */ public byte[] Padding14EC;
        /* 0x14F0 */ public Vector4f OffsetForFleetInteraction;
		/* 0x1500 */ public Vector4f OffsetForFrigateInteraction;

		/* 0x1510 */ public float FleetUIOrbitRate;
		/* 0x1514 */ public float FleetUIVerticalMotionDuration;
		/* 0x1518 */ public float FleetUIVerticalMotionAmplitude;

		/* 0x151C */ public Vector2f PitchForFrigateInteraction;
		/* 0x1524 */ public Vector2f RotationForFrigateInteraction;

		/* 0x152C */ public float InteractionModeBlendTime;
		/* 0x1530 */ public float InteractionModeFocusCamBlend;
		/* 0x1534 */ public float InteractionModeFoV;

		/* 0x1538 */ public float MinInteractFocusAngle;
		/* 0x153C */ public float ModelViewInterpTime;

		/* 0x1540 */ public float ThirdPersonBlendInTime;
		/* 0x1544 */ public float ThirdPersonBlendOutTime;

		/* 0x1548 */ public float ThirdPersonCollisionPushOffsetReducerStart;
		/* 0x154C */ public float ThirdPersonOffsetSpringTime;

		/* 0x1550 */ public bool MaxBob;

		/* 0x1554 */ public float PhotoModeMoveSpeed;
		/* 0x1558 */ public float PhotoModeTurnSpeed;
		/* 0x155C */ public float PhotoModeMaxDistance;
		/* 0x1560 */ public float PhotoModeMaxDistanceSpace;
		/* 0x1564 */ public float PhotoModeMaxDistanceClampForce;
		/* 0x1568 */ public float PhotoModeMaxDistanceClampBuffer;
		/* 0x156C */ public float PhotoModeCollisionRadius;
		/* 0x1570 */ public float PhotoModeRollSpeed;
		/* 0x1574 */ public float PhotoModeFlashDuration;
		/* 0x1578 */ public float PhotoModeFlashIntensity;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x157C */ public byte[] Padding157C;
        /* 0x1580 */ public Vector4f PhotoModeShipOffset;

		/* 0x1590 */ public float RunningFoVAdjust;
		/* 0x1594 */ public float MeleeBoostedFoV;
		/* 0x1598 */ public float MeleeFoV;
		/* 0x159C */ public float AerialViewDownDistance;
		/* 0x15A0 */ public float AerialViewPause;
		/* 0x15A4 */ public float AerialViewStartTime;
		/* 0x15A8 */ public float AerialViewBackTime;
		/* 0x15AC */ public float AerialViewBlendTime;
		/* 0x15B0 */ public TkCurveType AerialViewCurve;
		/* 0x15B4 */ public GcCameraAerialViewData BeaconTransition;
		/* 0x15E4 */ public GcCameraAerialViewData SignalTransition;
		/* 0x1614 */ public GcCameraAerialViewData WaypointTransition;
		/* 0x1644 */ public GcCameraAerialViewData RadioTowerTransition;
		/* 0x1674 */ public float ScreenshotHorizonHeight;
		/* 0x1678 */ public float ScreenshotHorizonFaceFactor;
		/* 0x167C */ public float ScreenshotBendDownAmount;
		/* 0x1680 */ public float ScreenshotRightDistance;
		/* 0x1684 */ public float ScreenshotBackDistance;
		/* 0x1688 */ public float ScreenshotInTime;
		/* 0x168C */ public float ScreenshotOutTime;
		/* 0x1690 */ public float ShipCamSpringStrengthMin;
		/* 0x1694 */ public float ShipCamSpringStrengthMax;
		/* 0x1698 */ public float ShipCamTurn;
		/* 0x169C */ public float ShipCamPitch;
		/* 0x16A0 */ public float ShipCamPitchMod;
		/* 0x16A4 */ public float ShipCamLookInterp;
		/* 0x16A8 */ public float ShipCamMinReturnTime;
		/* 0x16AC */ public float ShipCamReturnTime;
		/* 0x16B0 */ public float ShipCamMotionTurn;
		/* 0x16B4 */ public float ShipCamMotionPitch;
		/* 0x16B8 */ public float ShipCamMotionPitchMod;
		/* 0x16BC */ public float ShipCamMotionMaxLagTurnAngle;
		/* 0x16C0 */ public float ShipCamMotionMaxLagPitchAngle;
		/* 0x16C4 */ public float ShipCamMotionInterp;
		/* 0x16C8 */ public float ShipCamRollAmountMin;
		/* 0x16CC */ public float ShipCamRollAmountMax;
		/* 0x16D0 */ public float ShipCamRollSpeedScaler;
		/* 0x16D4 */ public float ShipCamAimFOV;
		/* 0x16D8 */ public float MouseSensitivity;
		/* 0x16DC */ public float ModelViewRotateSpeed;
		/* 0x16E0 */ public float ModelViewMouseRotateSpeed;
		/* 0x16E4 */ public float ModelViewMouseRotateSnapStrength;
		/* 0x16E8 */ public float ModelViewMouseMoveSpeed;
		/* 0x16EC */ public float ModelViewDistSpeed;
		/* 0x16F0 */ public float ModelViewMinDist;
		/* 0x16F4 */ public float ModelViewMaxDist;
		/* 0x16F8 */ public float ModelViewDefaultPitch;
		/* 0x16FC */ public float ModelViewDefaultYaw;
		/* 0x1700 */ public bool DebugMoveCam;
		/* 0x1704 */ public float DebugMoveCamSpeed;
		/* 0x1708 */ public float DebugMoveCamHeight;
		/* 0x170C */ public bool DebugAICam;
		/* 0x1710 */ public float DebugAICamUp;
		/* 0x1714 */ public float DebugAICamAt;
		/* 0x1718 */ public float PainShakeTime;
		/* 0x171C */ public float ShipShakeDamper;
		/* 0x1720 */ public float IndoorCamShakeDamper;
		/* 0x1724 */ public float FirstPersonSlerpAway;
		/* 0x1728 */ public float FirstPersonSlerpTowards;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x172C */ public byte[] Padding172C;

        [NMS(Size = 0x20)]
        /* 0x1730 */ public GcCameraShakeData[] CameraShakeTable;
        /* 0x2F30 */ public float BobAmount;
		/* 0x2F34 */ public float BobFactor;
		/* 0x2F38 */ public float BobFocus;
		/* 0x2F3C */ public float BobRollFactor;
		/* 0x2F40 */ public float BobRollAmount;
		/* 0x2F44 */ public float BobRollOffset;
		/* 0x2F48 */ public float BobFwdAmount;
		/* 0x2F4C */ public float CamSeed1;
		/* 0x2F50 */ public float CamSeed2;
		/* 0x2F54 */ public float CamWander1Phase;
		/* 0x2F58 */ public float CamWander2Phase;
		/* 0x2F5C */ public float CamWander1Amplitude;
		/* 0x2F60 */ public float CamWander2Amplitude;
		/* 0x2F64 */ public float DebugSpaceStationTeleportOffset;
		/* 0x2F68 */ public float DebugCameraSlowFactor;
		/* 0x2F6C */ public float DebugCameraFastFactor;
		/* 0x2F70 */ public float DebugCameraSpaceFastFactor;
		/* 0x2F74 */ public float OffsetCamFOV;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2F78 */ public byte[] Padding2F78;
        /* 0x2F80 */ public Vector4f OffsetCamOffset;
        /* 0x2F90 */ public Vector4f OffsetCamRotation;

        /* 0x2FA0 */ public float ObjectFocusTime;
        /* 0x2FA4 */ public float CharCamFocusHeight;
        /* 0x2FA8 */ public float CharCamMaxDistance;
        /* 0x2FAC */ public float CharCamMinDistance;
        /* 0x2FB0 */ public float CharCamHeight;
        /* 0x2FB4 */ public float CharCamOffsetTime;
        /* 0x2FB8 */ public float CharCamAutoDirStartTime;
        /* 0x2FBC */ public float CharCamLookOffset;
        /* 0x2FC0 */ public float CharCamLookOffsetFactor;
        /* 0x2FC4 */ public float CharCamDeflectSpeed;
        /* 0x2FC8 */ public float CharCamMinSpeed;
        /* 0x2FCC */ public float CharCamRightStickX;
        /* 0x2FD0 */ public float CharCamRightStickY;
        /* 0x2FD4 */ public float FirstPersonCamHeight;
        /* 0x2FD8 */ public float FirstPersonFoV;
        /* 0x2FDC */ public float ThirdPersonFoV;
        /* 0x2FE0 */ public float FirstPersonZoom1FoV;
        /* 0x2FE4 */ public float FirstPersonZoom2FoV;
        /* 0x2FE8 */ public float ShipFoVMin;
        /* 0x2FEC */ public float ShipFoVMin2;
        /* 0x2FF0 */ public float ShipFoVMax;
        /* 0x2FF4 */ public float ShipWarpFoV;
        /* 0x2FF8 */ public float ShipFoVMin3rdPerson;
        /* 0x2FFC */ public float ShipFoVMax3rdPerson;
        /* 0x3000 */ public float ShipFoVBoost;
        /* 0x3004 */ public float ShipFoVMiniJump;
        /* 0x3008 */ public float ShipFoVSpring;
        /* 0x300C */ public float ShipMiniJumpFoVSpring;
        /* 0x3010 */ public float FoVSpring;
        /* 0x3014 */ public float FoVAdjust;
        /* 0x3018 */ public bool FollowDrawCamProbes;

        [NMS(Size = 0x3, Ignore = true)]
        /* 0x3019 */ public byte[] Padding3019;

        /* 0x301C */ public GcCameraAnimationData AmbientCameraAnimations;
        /* 0x30A0 */ public GcCameraAnimationData AmbientDroneAnimations;
        [NMS(Size = 0x80)]
        /* 0x3124 */ public string CameraAmbientAnimationsData;
        /* 0x31A4 */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x31A8 */ public float CameraAmbientAutoSwitchMaxTime;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x31AC */ public byte[] Padding31AC;
        /* 0x31B0 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x3260 */ public TkModelRendererData CameraNPCShopInteraction;

        [NMS(Size = 0x4)]
        /* 0x3310 */ public Vector4f[] SavedCameraPositions;

        [NMS(Size = 0x40, Ignore = true)]
        /* 0x3350 */ public byte[] Padding3350;

        [NMS(Size = 0x4)]
        /* 0x3390 */ public Vector4f[] SavedCameraFacing;
        /* 0x33D0 */ public GcCameraWarpSettings WarpSettings;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3424 */ public byte[] EndPadding;

    }

}
