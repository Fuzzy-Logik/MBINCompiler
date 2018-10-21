﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD77B64DA9352885D)]
    public class GcMissionSequenceSignalGalacticPoint : GameComponent {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcMissionGalacticPoint Target;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
