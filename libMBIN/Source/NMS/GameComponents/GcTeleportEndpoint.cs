﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x377F9168390C70C1)]
    public class GcTeleportEndpoint : GameComponentType {

        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x20 */ public Vector4f Position;
        /* 0x30 */ public Vector4f Facing;
		public enum TeleporterTypeEnum { Base, SpaceStation, Atlas, PlanetAwayFromShip, ExternalBase, EmergencyGalaxyFix }
		public TeleporterTypeEnum TeleporterType;
        [NMS(Size = 0x40)]
        /* 0x44 */ public string Name;
        [NMS(Size = 0xC)]
        /* 0x84 */ public byte[] EndPadding;
    }
}
