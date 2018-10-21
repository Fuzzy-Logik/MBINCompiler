﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD16EDF43730DB8AE)]
    public class GcCreatureTypes : GameComponent {

		public enum CreatureTypeEnum { None, Bird, FlyingLizard, FlyingSnake, Butterfly, Beetle, Fish, Shark, Crab, Snake, Dino, Antelope, Rodent, Cat, Fiend, Drone, Quad, Walker, Predator, PlayerPredator, Prey, Passive, Brainless }
		public CreatureTypeEnum CreatureType;
    }
}
