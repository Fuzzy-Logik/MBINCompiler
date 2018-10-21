﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xA055E241AA30DB8)]
    public class GcInteractionBuffer : GameComponentType {

        public List<GcInteractionData> Interactions;
    }
}
