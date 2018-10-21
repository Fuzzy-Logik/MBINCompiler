﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE257E78487E5727A)]
    public class GcGenericIconTypes : GameComponent {

		public enum GenericIconTypeEnum { None, Interaction, SpaceStation, SpaceAnomaly, SpaceAtlas }
		public GenericIconTypeEnum GenericIconType;
    }
}
