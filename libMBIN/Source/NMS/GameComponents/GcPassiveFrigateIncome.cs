﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x2E3E5DACD50B6024)]
    public class GcPassiveFrigateIncome : GameComponentType {

        [NMS(Size = 0x10)]
        /* 0x00 */ public string IncomeID;
        /* 0x10 */ public GcInventoryType IncomeType;
        /* 0x14 */ public int AmountOfIncomeRewarded;
        /* 0x18 */ public int ForEveryXAmountOfTheStat;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
