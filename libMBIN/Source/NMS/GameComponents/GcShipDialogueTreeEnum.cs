﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x27B4FEC32B042806)]
    public class GcShipDialogueTreeEnum : GameComponent {

		public enum DialogueTreeEnum { Bribe, Beg, Ambush, Trade, Help, Goods, Hostile }
		public DialogueTreeEnum DialogueTree;
    }
}
