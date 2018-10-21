﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0x25C7464DF342E314)]
    public class GcDebrisData : GameComponent {

        /* 0x00 */ public TkModelResource Filename;
        /* 0x84 */ public int Number;
        /* 0x88 */ public float Radius;
        /* 0x8C */ public float Scale;
        /* 0x90 */ public float Speed;
        /* 0x94 */ public float AngularSpeed;
        /* 0x98 */ public GcSeed OverrideSeed;
    }
}
