﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8429195766863F79)]
    public class GcRewardSpecificSpecial : GameComponentType {

        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x20)]
        public string Message;
    }
}
