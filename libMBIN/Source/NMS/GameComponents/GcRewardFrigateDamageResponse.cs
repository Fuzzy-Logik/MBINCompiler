﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8441E6AA6DAFDE25)]
    public class GcRewardFrigateDamageResponse : GameComponent {

		public enum ResponseEnum { StayOut, ReturnHome, CheckForMoreDamage, ShowDamagedCaptain, ShowExpeditionCaptian }
		public ResponseEnum Response;
    }
}
