﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2CCEA81A61F5A8D4)]
    public class GcAISpaceshipRoles : GameComponentType {

		public enum AIShipRoleEnum { Standard, Freighter, CapitalFreighter, SmallFreighter, TinyFreighter, Frigate }
		public AIShipRoleEnum AIShipRole;
    }
}
