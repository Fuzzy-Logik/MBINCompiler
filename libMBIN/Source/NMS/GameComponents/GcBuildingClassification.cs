﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF10DCBCA48632B34)]
    public class GcBuildingClassification : GameComponent {

		public enum BuildingClassEnum { None, TerrainResource, Shelter, Abandoned, Terminal, Shop, Outpost, Waypoint, Beacon, RadioTower, Observatory, Depot, Factory, Harvester,
                                        Plaque, Monolith, Portal, Ruin, Debris, DamagedMachine, DistressSignal, LandingPad, Base, MissionTower, CrashedFreighter, GraveInCave,
                                        StoryGlitch, TreasureRuins, GameStartSpawn }
		public BuildingClassEnum BuildingClass;
    }
}
