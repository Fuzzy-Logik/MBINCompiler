﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1A1581EE742BF23E, Broken = true)]
    public class GcPlayerCharacterStateType : GameComponentType {

		public enum CharacterStateEnum { Idle, Jog, JogUphill, JogDownhill, SteepSlope, Sliding, Run, Airborne, JetpackBoost, RocketBoost, Swimming, Death, FullBodyOverride }
		public CharacterStateEnum CharacterState;
    }
}
