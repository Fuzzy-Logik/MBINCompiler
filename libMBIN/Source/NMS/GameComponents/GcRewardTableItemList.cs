﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4150DB7F9D5B8C28)]
    public class GcRewardTableItemList : GameComponent {

		public enum RewardChoiceEnum { GiveAll, Select, SelectAlways, TryEach, SelectSilent, TryFirst_ThenSelectAlways }
		public RewardChoiceEnum RewardChoice;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        public List<GcRewardTableItem> List;
    }
}
