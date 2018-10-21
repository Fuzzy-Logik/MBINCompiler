﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x85EAE598340B4C9E)]
    public class GcActionTriggerState : GameComponentType {

        [NMS(Size = 0x10)]
        public string StateID;
        public List<GcActionTrigger> Triggers;
    }
}
