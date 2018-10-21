﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, GUID = 0x8590A9E648CD8322)]
    public class GcRefinerUnitComponentData : GameComponentType {

        public GcMaintenanceComponentData MaintenanceData;
        public int NumInputs;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
