﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x63660285B883E92D)]
    public class TkNoiseOffsetEnum : ToolkitDataType {

		public enum OffsetTypeEnum { Zero, Base, All, SeaLevel }
		public OffsetTypeEnum OffsetType;
    }
}
