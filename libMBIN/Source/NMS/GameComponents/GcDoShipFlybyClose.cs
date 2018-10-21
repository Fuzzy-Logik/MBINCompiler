﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, Alignment = 0x8, GUID = 0x8CE133173CB7EA47)]
    public class GcDoShipFlybyClose : GameComponent {

        public float LockOffset;        // 42C80000h
        public float LockTime;          // 40A00000h
        public float LockSpread;        // 41200000h
        public bool StayCloseAtLowSpeed;// 0
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
