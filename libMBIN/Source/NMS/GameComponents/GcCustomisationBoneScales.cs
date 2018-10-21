﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xDDBA207312F77137)]
    public class GcCustomisationBoneScales : GameComponent {

        [NMS(Size = 0x20)]
        public string GroupTitle;
        [NMS(Size = 0x10)]
        public string ScaleBoneName;
        public List<float> Positions;
    }
}
