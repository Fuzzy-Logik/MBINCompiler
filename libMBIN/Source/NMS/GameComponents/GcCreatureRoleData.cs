﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x510, GUID = 0xDABD18060937B6DE)]
    public class GcCreatureRoleData : GameComponent {

        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public GcCreatureTypes CreatureType;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string CreatureId;
        /* 0x028 */ public GcCreatureRoleDescription Description;
        /* 0x068 */ public GcCreatureInfo Info;
        /* 0x500 */ public GcTerrainTileType TileType;
		public enum DietEnum { Carnivore, Omnivore, Herbivore }
		public DietEnum Diet;
        /* 0x508 */ public float BaseScale;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding48C;
    }
}
