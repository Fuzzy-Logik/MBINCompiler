﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD43AF1D3C4E374FD)]
    public class GcNetworkInterpolationComponentData : GameComponentType {

		public enum SynchroniseScaleEnum { Never, Once, Always }
		public SynchroniseScaleEnum SynchroniseScale;
    }
}
