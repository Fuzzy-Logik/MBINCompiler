﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD68554061D314110)]
    public class GcInventoryLayoutSizeType : GameComponentType {

		public enum SizeTypeEnum { SciSmall, SciMedium, SciLarge, FgtSmall, FgtMedium, FgtLarge, ShtSmall, ShtMedium, ShtLarge, DrpSmall, DrpMedium, DrpLarge,
            RoySmall, RoyMedium, RoyLarge, WeaponSmall, WeaponMedium, WeaponLarge, FreighterSmall, FreighterMedium, FreighterLarge, VehicleSmall, VehicleMedium,
            VehicleLarge, ChestSmall, ChestMedium, ChestLarge, ChestCapsule }
		public SizeTypeEnum SizeType;
    }
}
