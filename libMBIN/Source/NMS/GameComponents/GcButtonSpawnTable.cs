﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x88124B83B6861EAC)]
    public class GcButtonSpawnTable : GameComponentType {

        public List<GcButtonSpawn> ButtonSpawns;
    }
}
