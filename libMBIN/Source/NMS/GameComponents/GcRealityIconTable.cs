﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4230, GUID = 0xC70A517728774310)]
    public class GcRealityIconTable : GameComponentType {

        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;

        [NMS(Size = 9, EnumValue = new string[9] { "Fuel", "Metal", "Catalyst", "Stellar", "Flora", "Earth", "Exotic", "Special", "BuildingPart" })]
        /* 0x0318 */ public TkTextureResource[] SubstanceCategoryIcons;

        [NMS(Size = 8, EnumValue = new string[8] { "Component", "Consumable", "Tradeable", "Curiousity", "BuildingPart", "Procedural", "Emote", "CustomisationPart" })]
        /* 0x07BC */ public TkTextureResource[] ProductCategoryIcons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x0BDC */ public TkTextureResource[] MissionFactionIcons;

        [NMS(Size = 0xF, EnumValue = new string[0xF] { "Unknown", "SolarSystem", "Planet", "Animal", "Flora", "Mineral", "Sector", "Building",
                                                       "Interactable", "Sentinel", "Starship", "Artifact", "Mystery", "Treasure", "Control"})]
        /* 0x0F78 */ public TkTextureResource[] BinocularDiscoveryIcons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Mining", "HighTech", "Trading", "Manufacturing", "Fusion", "Scientific", "PowerGeneration" })]
        /* 0x1734 */ public TkTextureResource[] DiscoveryPageTradingIcons;

        [NMS(Size = 0x3, EnumValue = new string[3] { "Low", "Default", "High" })]
        /* 0x1AD0 */ public TkTextureResource[] DiscoveryPageConflictIcons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x1C5C */ public TkTextureResource[] DiscoveryPageRaceIcons;

        /* 0x1FF8 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        /* 0x2008 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x2018 */ public List<TkTextureResource> RepairTechIcons;

        // enum struct: GcRealityGameIcons
        [NMS(Size = 0x42, EnumValue = new string[0x42] { "Stamina", "NoStamina", "EnergyCharge", "Scanner", "NoScanner", "Grave", "Resources",
            "Inventory", "InventoryFull", "RareItems", "Pirates", "PirateScan", "Drone", "Quad", "Walker", "DroneOff", "Police", "AtlasStation",
            "BlackHole", "SaveGame", "Jetpack", "JetpackEmpty", "VehicleBoost", "VehicleBoostRecharge", "Fuel", "GekStanding", "VykeenStanding",
            "KorvaxStanding", "GekDiamondStanding", "VykeenDiamondStanding", "KorvaxDiamondStanding", "TradeGuildStanding", "WarGuildStanding",
            "ExplorationGuildStanding", "TradeGuildDiamondStanding", "WarGuildDiamondStanding", "ExplorationGuildDiamondStanding", "GMPathToCentre",
            "GMAtlas", "GMBlackHole", "GMUserWaypoint", "GMUserMission", "TransferPersonal", "TransferPersonalCargo", "TransferShip", "TransferBike",
            "TransferBuggy", "TransferTruck", "TransferWheeledBike", "TransferHovercraft", "TransferSubmarine", "TransferFreighter", "TransferBase",
            "HazardIndicatorHot", "HazardIndicatorCold", "HazardIndicatorRadiation", "HazardIndicatorToxic", "TerrainAdd", "TerrainRemove", "TerrainUndo",
            "SpacePhone", "GarageMarkerBuggy", "GarageMarkerBike", "GarageMarkerTruck", "GarageMarkerWheeledBike", "GarageMarkerHovercraft"})]
        /* 0x2028 */ public TkTextureResource[] GameIcons;
    }
}
