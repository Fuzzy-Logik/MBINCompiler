﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0x8AC5D18F92C33E43)]
    public class GcSpaceshipComponentData : GameComponent {

        /* 0x00 */ public GcSpaceshipClasses ShipClass;
        [NMS(Size = 0x80)]
        /* 0x04 */ public string Cockpit;
        /* 0x84 */ public float MaxHeadTurn;
        /* 0x88 */ public float MaxHeadPitchUp;
        /* 0x8C */ public float MaxHeadPitchDown;
        /* 0x90 */ public int BaseHealth;
        /* 0x94 */ public float FoVFixedDistance;
    }
}
