﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x91B99EE82BD627C2)]
    public class GcRewardTeleport : GameComponentType {

		public enum TeleportRewardTypeEnum { None, ToBase, Station0, Station1, Station2, Station3, Atlas }
		public TeleportRewardTypeEnum TeleportRewardType;
    }
}
