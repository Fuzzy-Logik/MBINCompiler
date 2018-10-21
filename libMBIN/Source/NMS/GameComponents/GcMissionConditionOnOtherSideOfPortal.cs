﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2, GUID = 0x23EDE32E8B69B0AE)]
    public class GcMissionConditionOnOtherSideOfPortal : GameComponentType {

        /* 0x0 */ public bool TestForRegularPortal;
        /* 0x1 */ public bool TestForStoryPortal;
    }
}
