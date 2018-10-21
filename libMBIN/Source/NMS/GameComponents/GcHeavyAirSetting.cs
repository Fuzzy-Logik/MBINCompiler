﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0x57B4A038FBBAC4CE)]
    public class GcHeavyAirSetting : GameComponentType {

        [NMS(Size = 5)]
        public GcHeavyAirSettingValues[] Settings;
    }
}
