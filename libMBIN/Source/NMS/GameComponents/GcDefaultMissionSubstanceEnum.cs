﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x751F47F5E80735E)]
    public class GcDefaultMissionSubstanceEnum : GameComponent {

		public enum DefaultSubstanceTypeEnum { None, PrimarySubstance, SecondarySubstance }
		public DefaultSubstanceTypeEnum DefaultSubstanceType;
    }
}
