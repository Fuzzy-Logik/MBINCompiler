﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE550096D7C607FFF)]
    public class GcCreatureNearbyEvent : GameComponentType {

        public GcCreatureAlertData AlertTable;
        public bool Inverse;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
