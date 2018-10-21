﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x39C089B84169B9D2)]
    public class GcMissionConditionExpeditionCount : GameComponent {

        public int ExpeditionCount;
        public bool OnlyCountIfActive;
        public bool OnlyCountIfFueled;
        public bool OnlyCountAwaitingDebrief;
        public bool ActiveExpeditionsCountAsFueled;
        public TkEqualityEnum Test;
    }
}
