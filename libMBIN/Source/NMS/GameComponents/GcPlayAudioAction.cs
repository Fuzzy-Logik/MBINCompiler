﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC30E8192B2598E1A)]
    public class GcPlayAudioAction : GameComponentType {

        [NMS(Size = 0x80)]
        public string Sound;
        public bool UseOcclusion;
        public float OcclusionRadius;
    }
}
