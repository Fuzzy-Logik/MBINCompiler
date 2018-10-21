﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB71A10E23C5105BD)]
    public class GcBaseBuildingProperties : GameComponent {

        [NMS(Size = 0x10)]
        public string DefaultInBaseObject;
        [NMS(Size = 0x10)]
        public string DefaultOnTerrainObject;
        [NMS(Size = 0x10)]
        public string DefaultInFreighterObject;
    }
}
