﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0x379144CD81FEFD57)]
    public class GcMissionSequenceTeleport : GameComponentType {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
        /* 0x100 */ public GcTeleporterType TeleporterType;
        /* 0x104 */ public bool DoCameraShake;
        /* 0x105 */ public bool DoWhiteout;
        /* 0x108 */ public float SequenceTime;
        /* 0x10C */ public float EffectTime;

    }
}
