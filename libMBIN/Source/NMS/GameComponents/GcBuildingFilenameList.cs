﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x7400, GUID = 0x4DF76B86F24FAEC)]
    public class GcBuildingFilenameList : GameComponentType {

        [NMS(Size = 0x1D, EnumValue = new string[0x1D] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch", "TreasureRuins", "GameStartSpawn"
            })]
        public GcBuildingFilename[] BuildingFiles;
    }
}
