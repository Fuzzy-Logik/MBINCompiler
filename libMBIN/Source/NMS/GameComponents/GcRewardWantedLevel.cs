﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x20A0105001737A1E)]
    public class GcRewardWantedLevel : GameComponentType {

        [NMS(Size = 0x20)]
        public string Message;
        public int Level;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
