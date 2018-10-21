﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4908B03210959014)]
    public class GcGameMode : GameComponentType {

		public enum PresetGameModeEnum { Unspecified, Normal, Creative, Survival, Ambient, Permadeath }
		public PresetGameModeEnum PresetGameMode;
    }
}
