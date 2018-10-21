﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x0C, GUID = 0xC6BACB251FBD021)]
    public class GcBuildingSpawnSlot : GameComponent {

        public bool HasBuilding;
        public int BuildingDataIndex;
        public float Probability;
    }
}
