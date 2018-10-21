﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x58FBEFB63A146EB6)]
    public class GcButtonSpawn : GameComponent {

        /* 0x00 */ public TkInputEnum Button;
		public enum EventEnum { None, Pirates, Police, Traders, Walker }
		public EventEnum Event;
        /* 0x08 */ public GcButtonSpawnOffset Offset;
    }
}
