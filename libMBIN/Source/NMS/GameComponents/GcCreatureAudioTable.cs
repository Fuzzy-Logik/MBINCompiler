﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7D0676974C8E6A21)]
    public class GcCreatureAudioTable : GameComponent {

        public List<GcCreatureVocalSoundData> Table;
    }
}
