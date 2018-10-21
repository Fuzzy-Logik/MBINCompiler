﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x88D5BE0AA7AE6B79)]
    public class GcPhotoPlant : GameComponentType {

		public enum PhotoPlantTypeEnum { Zinc, Thamium, Platinum }
		public PhotoPlantTypeEnum PhotoPlantType;
    }
}
