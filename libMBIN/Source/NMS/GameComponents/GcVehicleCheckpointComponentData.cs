﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x28BD4D157D6849F4)]
    public class GcVehicleCheckpointComponentData : GameComponent {

		public enum CheckpointTypeEnum { Checkpoint, Start, Finish }
		public CheckpointTypeEnum CheckpointType;
		public enum RaceTypeEnum { Vehicle, Spaceship }
		public RaceTypeEnum RaceType;
        public float Radius;
    }
}
