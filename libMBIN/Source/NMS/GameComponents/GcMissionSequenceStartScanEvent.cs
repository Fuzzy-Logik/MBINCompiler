﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB0, Alignment = 0x8, GUID = 0xC9C6025A0E94ED85)]
    public class GcMissionSequenceStartScanEvent : GameComponentType {

        /* 0x000 */ public GcPlayerMissionParticipantType Participant;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;
        [NMS(Size = 0x20)]
        /* 0x008 */ public string Event;
        /* 0x028 */ public float Time;
        /* 0x029 */ public bool AllowOtherPlayerBase;
        [NMS(Size = 0x80)]
        /* 0x02D */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
