﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x81D9597B7AE1CF72)]
    public class GcCreatureFootParticleSingleData : GameComponent {

        [NMS(Size = 0x10)]
        public string EffectName;

        public float Scale;
        public float MinCreatureSize;
        public float MaxCreatureSize;
		public enum MoveSpeedEnum { Always, Walk, Run }
		public MoveSpeedEnum MoveSpeed;
    }
}
