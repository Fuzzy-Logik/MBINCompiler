﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7C5DB65E2CF0F90)]
    public class GcMissionConditionNPCHabitationHasWorker : GameComponentType {

        public GcNPCHabitationType WorkerType;
		public enum WorkerInCurrentBaseEnum { DontCare, Yes, No }
		public WorkerInCurrentBaseEnum WorkerInCurrentBase;
    }
}
