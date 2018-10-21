﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x304, GUID = 0x959970D1E4FDF510)]
    public class GcDisplayText : GameComponentType {

		public enum HUDTextDisplayTypeEnum { Full, Compact, EyeLevel, Prompt, Tooltip }
		public HUDTextDisplayTypeEnum HUDTextDisplayType;

        [NMS(Size = 0x100)]
        public string Title;
        [NMS(Size = 0x100)]
        public string Subtitle1;
        [NMS(Size = 0x100)]
        public string Subtitle2;
    }
}
