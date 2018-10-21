﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x1DFBCEEAFDE9D7C6)]
    public class GcActionTrigger : GameComponent {

        public GameComponent Trigger;
        public List<GameComponent> Action;
    }
}
