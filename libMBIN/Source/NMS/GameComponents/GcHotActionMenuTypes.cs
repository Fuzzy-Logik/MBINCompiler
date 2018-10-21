﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1BAE16556CE24834)]
    public class GcHotActionMenuTypes : GameComponent {

		public enum HotActionMenuTypesEnum { OnFoot, InShip, InExocraft }
		public HotActionMenuTypesEnum HotActionMenuTypes;
    }
}
