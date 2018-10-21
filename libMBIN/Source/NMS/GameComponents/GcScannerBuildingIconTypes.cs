﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x41D88331C68B32DC)]
    public class GcScannerBuildingIconTypes : GameComponentType {

		public enum ScanBuildingIconTypesEnum { None, Generic, Shelter, Relic, Factory, Unknown, Distress, Beacon, Waypoint, SpaceStation, TechResource, FuelResource, MineralResource, SpaceAnomaly, SapceAtlas }
		public ScanBuildingIconTypesEnum ScanBuildingIconTypes;
    }
}
