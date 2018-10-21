﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCCEF65AB9E7A8042)]
    public class GcInteractionBufferType : GameComponent {

		public enum InterationBufferTypeEnum { Distress_Signal, Crate, Destructable, Terrain, Cost, Building, Creature, Maintenance, Personal, Personal_Maintenance }
		public InterationBufferTypeEnum InterationBufferType;
    }
}
