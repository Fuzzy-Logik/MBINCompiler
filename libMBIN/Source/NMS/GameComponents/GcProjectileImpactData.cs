﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9D38BEA536F71877)]
    public class GcProjectileImpactData : GameComponentType {

        [NMS(Size = 0x10)]
        /* 0x000 */ public string Effect;
        /* 0x010 */ public GcProjectileImpactType ImpactType;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
