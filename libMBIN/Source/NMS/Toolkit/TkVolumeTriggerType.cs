﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x12D45A89840E0777)]
    public class TkVolumeTriggerType : ToolkitData {

		public enum VolumeTriggerTypeEnum { Open, GenericInterior, GenericGlassInterior, Corridor, SmallRoom, LargeRoom, OpenCovered, HazardProtection, FieldBoundary, Custom_Biodome, Portal, VehicleBoost }
		public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
