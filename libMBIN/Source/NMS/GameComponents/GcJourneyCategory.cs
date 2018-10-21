﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA7F3AE06D8A09EE9)]
    public class GcJourneyCategory : GameComponent {

        /* 0x000 */ public GcJourneyCategoryType Type;
        /* 0x004 */ public GcMissionFaction Faction;
        [NMS(Size = 0x20)]
        /* 0x008 */ public string NameIDLower;
        [NMS(Size = 0x20)]
        /* 0x028 */ public string NameIDUpper;
        [NMS(Size = 0x20)]
        /* 0x048 */ public string DescriptionID;
        /* 0x068 */ public TkTextureResource IconOn;
        /* 0x0EC */ public TkTextureResource IconOff;
        /* 0x170 */ public List<GcJourneyMedal> Medals;
    }
}
