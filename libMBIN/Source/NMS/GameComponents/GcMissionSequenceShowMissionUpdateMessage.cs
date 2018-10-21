﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C, GUID = 0x85F5AD21EFF6A7AD)]
    public class GcMissionSequenceShowMissionUpdateMessage : GameComponent {

		public enum MissionUpdateMessageEnum { Start, End }
		public MissionUpdateMessageEnum MissionUpdateMessage;
        /* 0x4 */ public bool SetMissionSelected;
        /* 0x5 */ public bool WaitForMessageOver;
        /* 0x6 */ public bool ShowChangeMissionNotify;
		public enum PlayMusicStingEnum { None, Start, End }
		public PlayMusicStingEnum PlayMusicSting;
        [NMS(Size = 0x80)]
        /* 0xC */ public string DebugText;
    }
}
