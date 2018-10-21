﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF03F99B8CA594022)]
    public class GcDamageType : GameComponentType {

		public enum DamageTypeEnum { Gun, Laser, Shotgun, Burst, Rail, Explosion, Melee, ShipGun, ShipLaser, ShipShotgun, ShipMinigun, ShipRockets,
                                     ShipPlasma, VehicleGun, VehicleLaser, SentinelLaser, PlayerDamage, PlayerWeapons, ShipWeapons, VehicleWeapons }
		public DamageTypeEnum DamageType;
    }
}
