﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFDD9F1E5F1524FF4)]
    public class GcExpeditionDurationValues : GameComponentType {

        [NMS(Size = 0x5)]
        public int[] Duration;
    }
}
