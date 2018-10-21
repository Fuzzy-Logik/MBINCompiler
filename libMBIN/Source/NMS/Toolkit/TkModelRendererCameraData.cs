﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x4117A6369803D90B)]
    public class TkModelRendererCameraData : ToolkitComponent {

        public float Distance;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Offset;
        public float Pitch;
        public float Rotate;
        public float LightPitch;
        public float LightRotate;
        public TkCameraWanderData Wander;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding3C;
    }
}
