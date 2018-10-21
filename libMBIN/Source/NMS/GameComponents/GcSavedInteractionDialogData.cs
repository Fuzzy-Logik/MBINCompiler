﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xA80997A95CD03CAA)]
    public class GcSavedInteractionDialogData : GameComponent {

        public ulong Hash;
        [NMS(Size = 0x20)]
        public string Dialog;
    }
}
