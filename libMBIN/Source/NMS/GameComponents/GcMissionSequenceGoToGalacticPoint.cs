﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4D166CB02862AD83)]
    public class GcMissionSequenceGoToGalacticPoint : GameComponentType {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public GcMissionGalacticPoint Target;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
