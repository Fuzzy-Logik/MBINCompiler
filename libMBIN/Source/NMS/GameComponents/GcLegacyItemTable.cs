﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x4F3FAE85B4AF62AF)]
    public class GcLegacyItemTable : GameComponentType {

		/* 0x00 */ public List<GcLegacyItem> Table;
    }
}
