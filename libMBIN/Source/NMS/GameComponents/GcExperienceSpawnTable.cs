﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD6C7E7D9E60B1A2B)]
    public class GcExperienceSpawnTable : GameComponentType {

        public List<GcAIShipSpawnData> FlybySpawns;
        public List<GcAIShipSpawnData> OutpostSpawns;
        public List<GcAIShipSpawnData> SpaceFlybySpawns;
        public List<GcAIShipSpawnData> PirateSpawns;
        public List<GcAIShipSpawnData> PirateBattleSpawns;
        public List<GcAIShipSpawnData> PoliceSpawns;
        public List<GcAIShipSpawnData> TraderSpawns;
        public List<GcAIShipSpawnData> AmbientSpawns;
        public List<GcAIShipSpawnData> BattleSpawns;
        public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        public List<GcBountySpawnInfo> PirateBountySpawns;
    }
}
