﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xE47DADDDF1545211)]
    public class GcGenericMissionStage : GameComponentType {

        public List<GcGenericMissionVersionProgress> Versions;
        public NMSTemplate Stage;
    }
}
