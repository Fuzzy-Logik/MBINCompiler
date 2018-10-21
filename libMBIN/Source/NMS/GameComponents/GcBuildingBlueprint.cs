﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x9D0E732B5D903457)]
    public class GcBuildingBlueprint : GameComponent {

        [NMS(Size = 0x10)]
        public string ProductID;
        public int GroupId;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
