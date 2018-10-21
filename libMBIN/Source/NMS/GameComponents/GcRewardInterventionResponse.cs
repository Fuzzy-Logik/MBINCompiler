﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x699C68DBF05B93E7)]
    public class GcRewardInterventionResponse : GameComponentType {

		public enum ResponseTypeEnum { DontIntervene, InterveneWithMission, MissionSuccess, MissionFailure }
		public ResponseTypeEnum ResponseType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string MissionID;

    }
}
