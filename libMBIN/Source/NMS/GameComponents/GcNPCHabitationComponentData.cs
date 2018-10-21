﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6AA447716F6C436)]
    public class GcNPCHabitationComponentData : GameComponent {

        [NMS(Size = 0x10)]
        public string NPCSpawnLocator;

        public GcNPCHabitationType NPCHabitationType;
    }
}
