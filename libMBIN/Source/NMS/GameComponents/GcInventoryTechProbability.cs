﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6CAEF8DD21A894EA)]
    public class GcInventoryTechProbability : GameComponentType {

        [NMS(Size = 0x10)]
        public string Tech;
		public enum DesiredTechProbabilityEnum { Never, Rare, Common, Always }
		public DesiredTechProbabilityEnum DesiredTechProbability;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
