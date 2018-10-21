﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA6DA836AA3B7B1D2)]
    public class GcPhysicsCollisionGroups : GameComponent {

		public enum CollisionGroupEnum { Normal, Water, Terrain, Substance, Asteroid, TerrainInstance, TerrainActivated, Player, Creature, Spaceship, Debris, Shield, Waypoint, NetworkPlayer }
		public CollisionGroupEnum CollisionGroup;
    }
}
