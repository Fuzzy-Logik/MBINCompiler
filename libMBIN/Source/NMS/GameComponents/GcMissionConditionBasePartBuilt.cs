﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, Alignment = 0x8, GUID = 0xE2F5A0E5BEC5AA01)]
    public class GcMissionConditionBasePartBuilt : GameComponent {

        [NMS(Size = 0x10)]
        /* 0x00 */ public string PartID;
        /* 0x10 */ public int Count;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        /* 0x18 */ public GcBuildingPartSearchType Type;
		public enum PartInCurrentBaseEnum { DontCare, YesAllPlayerOwned }
		public PartInCurrentBaseEnum PartInCurrentBase;
    }
}
