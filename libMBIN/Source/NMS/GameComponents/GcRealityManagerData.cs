﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xAA20, GUID = 0xF55F6D34AB2EB58C)]
    public class GcRealityManagerData : GameComponentType {

        /* 0x0000 */ public int RealityIteration;

        [NMS(Size = 0xF)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;

        [NMS(Size = 0x4)]
        /* 0x01A8 */ public float[] CreatureDiscoverySizeMultiplier;

        /* 0x01B8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;

        /* 0x01C8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;

        [NMS(Size = 0x80)]
        /* 0x0368 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x03E8 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x0468 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x04E8 */ public string ProceduralProductTable;
        [NMS(Size = 0x80)]
        /* 0x0568 */ public string ProceduralTechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x05E8 */ public string LegacyItemConversionTable;

        /* 0x0668 */ public List<TkRawID> LegacyRepairTable;

        [NMS(Size = 0x80)]
        /* 0x0678 */ public string AlienWordsTable;

        /* 0x06F8 */ public List<NMSString0x80> AlienPuzzlesTables;

        [NMS(Size = 0x4C, EnumValue = new string[]
            {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue", "GuildEnvoy", "ManageFleet", "ManageExpeditions", "Frigate", "CustomiseCharacter",
                "CustomiseShip", "CustomiseWeapon", "CustomiseVehicle", "ClaimBaseAnywhere", "FleetNavigator", "FleetCommandPost", "StoryUtility",
                "MPMissionGiver", "SpecialsShop"
            })]
        /* 0x0708 */ public bool[] LoopInteractionPuzzles;

        [NMS(Size = 0x4C, EnumValue = new string[]
            {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue", "GuildEnvoy", "ManageFleet", "ManageExpeditions", "Frigate", "CustomiseCharacter",
                "CustomiseShip", "CustomiseWeapon", "CustomiseVehicle", "ClaimBaseAnywhere", "FleetNavigator", "FleetCommandPost", "StoryUtility",
                "MPMissionGiver", "SpecialsShop"
            })]
        /* 0x0754 */ public int[] InteractionPuzzlesIndexTypes;

        [NMS(Size = 0x7, EnumValue = new string[] { "NoWeighting", "MaxIsUncommon", "MaxIsRare", "MaxIsSuperRare", "MinIsUncommon", "MinIsRare", "MinIsSuperRare" })]
        /* 0x0884 */ public TkCurveType[] WeightingCurves;

        /* 0x08A0 */ public List<GcDamageMultiplierLookup> DamageTableMultiplier;

        [NMS(Size = 0x80)]
        /* 0x08B0 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0930 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x09B0 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0A30 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0AB0 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0B30 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0BB0 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0C30 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0CB0 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0D30 */ public string MaintenanceGroupsTable;

        /* 0x0DB0 */ public List<GcRefinerRecipe> RefinerRecipeTable1Input;
        /* 0x0DC0 */ public List<GcRefinerRecipe> RefinerRecipeTable2Input;
        /* 0x0DD0 */ public List<GcRefinerRecipe> RefinerRecipeTable3Input;
        /* 0x0DE0 */ public List<GcRefinerRecipe> CookingRecipeTable;

        // enum struct: GcShipWeapons
        [NMS(Size = 0x7, EnumValue = new string[7] { "Laser", "Projectile", "Shotgun", "Minigun", "Plasma", "Missile", "Rocket"})]
        /* 0x0DF0 */ public GcShipWeaponData[] ShipWeapons;

        [NMS(Size = 0xA, EnumValue = new string[0xA] { "Bolt", "Shotgun", "Burst", "Laser", "Rail", "Grenade", "MineGrenade", "Scope", "FrontShield", "TerrainEdit" })]
        /* 0x0FB0 */ public GcPlayerWeaponData[] PlayerWeapons;

        // enum struct: GcVehicleType
        [NMS(Size = 0x6, EnumValue = new string[6] { "Buggy", "Bike", "Truck", "WheeledBike", "Hovercraft", "Submarine" })]
        /* 0x1050 */ public TkIDArray[] DefaultVehicleLoadout;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x10B0 */ public NMSString0x10[] FactionStandingIDs;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x1120 */ public NMSString0x20[] FactionNames;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x1200 */ public GcNumberedTextList[] FactionClients;

        [NMS(Size = 0x9, EnumValue = new string[9] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy", "Photo", "Feeding" })]
        /* 0x12FC */ public GcNumberedTextList[] MissionNameFormats;

        [NMS(Size = 0x9, EnumValue = new string[9] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy", "Photo", "Feeding" })]
        /* 0x1440 */ public GcNumberedTextList[] MissionNameAdjectives;

        [NMS(Size = 0x9, EnumValue = new string[9] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy", "Photo", "Feeding" })]
        /* 0x1584 */ public GcNumberedTextList[] MissionNameNouns;

        [NMS(Size = 0x3)]
        /* 0x16C8 */ public float[] WeightedTextWeights;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x16D4 */ public byte[] Padding16D4;

        /* 0x16D8 */ public GcRealityIconTable Icons;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x5908 */ public byte[] Padding5908;

        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        /* 0x5910 */ public Colour[] HazardColours;

        [NMS(Size = 3, EnumValue = new string[3] { "Common", "Uncommon", "Rare" })]
        /* 0x5970 */ public Colour[] RarityColours;

        [NMS(Size = 9, EnumValue = new string[9] { "Fuel", "Metal", "Catalyst", "Stellar", "Flora", "Earth", "Exotic", "Special", "BuildingPart" })]
        /* 0x59A0 */ public Colour[] SubstanceCategoryColours;

        [NMS(Size = 9, EnumValue = new string[9] { "Fuel", "Metal", "Catalyst", "Stellar", "Flora", "Earth", "Exotic", "Special", "BuildingPart" })]
        /* 0x5A30 */ public TkTextureResource[] SubstanceChargeIcons;

        // enum struct: GcStatsTypes
        [NMS(Size = 0x7F, EnumValue = new string[0x7F]
            {
                "Unspecified", "Weapon_Laser", "Weapon_Laser_Damage", "Weapon_Laser_Mining_Speed", "Weapon_Laser_HeatTime", "Weapon_Laser_Bounce",
                "Weapon_Laser_ReloadTime", "Weapon_Laser_Recoil", "Weapon_Laser_Drain", "Weapon_Laser_StrongLaser", "Weapon_Laser_ChargeTime",
                "Weapon_Projectile", "Weapon_Projectile_Damage", "Weapon_Projectile_Range", "Weapon_Projectile_Rate", "Weapon_Projectile_ClipSize",
                "Weapon_Projectile_ReloadTime", "Weapon_Projectile_Recoil", "Weapon_Projectile_Bounce", "Weapon_Projectile_Homing",
                "Weapon_Projectile_Dispersion", "Weapon_Projectile_BulletsPerShot", "Weapon_Projectile_MaximumCharge", "Weapon_Rail", "Weapon_Shotgun",
                "Weapon_Burst", "Weapon_Grenade", "Weapon_Grenade_Damage", "Weapon_Grenade_Radius", "Weapon_Grenade_Speed", "Weapon_Grenade_Bounce",
                "Weapon_Grenade_Homing", "Weapon_Grenade_Clusterbomb", "Weapon_TerrainEdit", "Weapon_MineGrenade", "Weapon_FrontShield", "Weapon_Scope",
                "Weapon_Scan", "Weapon_Scan_Radius", "Weapon_Scan_Recharge_Time", "Weapon_Scan_Types", "Weapon_Scan_Binoculars",
                "Weapon_Scan_Discovery_Creature", "Weapon_Scan_Discovery_Flora", "Weapon_Scan_Secondary", "Weapon_Scan_Terrain_Resource",
                "Suit_Armour_Health", "Suit_Armour_Shield", "Suit_Armour_Shield_Strength", "Suit_Energy", "Suit_Energy_Regen", "Suit_Protection",
                "Suit_Protection_Cold", "Suit_Protection_Heat", "Suit_Protection_Toxic", "Suit_Protection_Radiation", "Suit_Underwater",
                "Suit_DamageReduce_Cold", "Suit_DamageReduce_Heat", "Suit_DamageReduce_Toxic", "Suit_DamageReduce_Radiation", "Suit_Stamina_Strength",
                "Suit_Stamina_Speed", "Suit_Jetpack", "Suit_Jetpack_Tank", "Suit_Jetpack_Drain", "Suit_Jetpack_Ignition", "Suit_Jetpack_DoubleJump",
                "Suit_Utility", "Ship_Weapons_Guns", "Ship_Weapons_Guns_Damage", "Ship_Weapons_Guns_Rate", "Ship_Weapons_Guns_HeatTime",
                "Ship_Weapons_Guns_CoolTime", "Ship_Weapons_Guns_Scale", "Ship_Weapons_Guns_BulletsPerShot", "Ship_Weapons_Guns_Dispersion",
                "Ship_Weapons_Guns_Range", "Ship_Weapons_Guns_Damage_Radius", "Ship_Weapons_Lasers", "Ship_Weapons_Lasers_Damage",
                "Ship_Weapons_Lasers_HeatTime", "Ship_Weapons_Missiles", "Ship_Weapons_Missiles_NumPerShot", "Ship_Weapons_Missiles_Speed",
                "Ship_Weapons_Missiles_Damage", "Ship_Weapons_Missiles_Size", "Ship_Weapons_Shotgun", "Ship_Weapons_MiniGun", "Ship_Weapons_Plasma",
                "Ship_Weapons_Rockets", "Ship_Armour_Shield", "Ship_Armour_Shield_Strength", "Ship_Armour_Health", "Ship_Scan", "Ship_Scan_EconomyFilter",
                "Ship_Scan_ConflictFilter", "Ship_Hyperdrive", "Ship_Hyperdrive_JumpDistance", "Ship_Hyperdrive_JumpsPerCell", "Ship_Launcher",
                "Ship_Launcher_TakeOffCost", "Ship_PulseDrive", "Ship_PulseDrive_MiniJumpFuelSpending", "Ship_Boost", "Ship_Maneuverability",
                "Ship_BoostManeuverability", "Ship_Teleport", "Freighter_Hyperdrive", "Freighter_Hyperdrive_JumpDistance", "Vehicle_Boost",
                "Vehicle_Engine", "Vehicle_Scan", "Vehicle_EngineFuelUse", "Vehicle_EngineTopSpeed", "Vehicle_BoostSpeed", "Vehicle_BoostTanks",
                "Vehicle_Grip", "Vehicle_SkidGrip", "Vehicle_Laser", "Vehicle_LaserDamage", "Vehicle_LaserHeatTime", "Vehicle_LaserStrongLaser",
                "Vehicle_Gun", "Vehicle_GunDamage", "Vehicle_GunHeatTime", "Vehicle_GunRate"
            })]
        /* 0x5ED4 */ public TkTextureResource[] StatCategoryIcons;

        [NMS(Size = 5, EnumValue = new string[5] { "Suit", "Weapon", "Ship", "Freighter", "Vehicle" })]
        /* 0xA050 */ public GcStats[] Stats;

        /* 0xA0A0 */ public GcTechList StationTechShops;

        [NMS(Size = 0xD)]
        /* 0xA0B0 */ public GcTechList[] PlanetTechShops;

        /* 0xA180 */ public GcTradeSettings TradeSettings;
        /* 0xA910 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xA930 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xA950 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xA970 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xA990 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xA9B0 */ public List<int> SuitUpgradePrices;
        /* 0xA9C0 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xA9D0 */ public List<int> SuitCargoUpgradePrices;
        /* 0xA9E0 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xA9F0 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special"})]         // not sure about these values....
        /* 0xAA00 */ public float[] NormalizedPriceLimits;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0xAA14 */ public byte[] EndPadding;
    }
}
