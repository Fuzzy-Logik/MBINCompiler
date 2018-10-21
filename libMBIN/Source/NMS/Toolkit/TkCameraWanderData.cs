﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xE99F6B225B893276)]
    public class TkCameraWanderData : ToolkitData {

        public bool CamWander;
        public float CamWanderPhase;
        public float CamWanderAmplitude;
    }
}
