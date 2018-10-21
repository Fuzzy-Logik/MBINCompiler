﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6EB3418A4E1F3123)]
    public class GcTurretComponentData : GameComponent {

		public enum GunTypeEnum { Laser, Projectile, Missile }
		public GunTypeEnum GunType;
    }
}
