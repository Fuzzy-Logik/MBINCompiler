﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace libMBIN.NMS.Toolkit {

    [NMS( Size = 0x50, GUID = 0x14C032849E45EE8D )]
    public class TkAnimNodeData : ToolkitData, ISerialize {

        [NMS( Size = 0x40 )]
        /* 0x00 */ public string Node;

        /* 0x40 */ public bool CanCompress; // set to 0xFE, with following 3 padding bytes also set to 0xFE, might be padding indicating that this is 0? currently treated as 1...

        /* 0x44 */ public int RotIndex;
        /* 0x48 */ public int TransIndex;
        /* 0x4C */ public int ScaleIndex;

        public bool OnSerialize( BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex ) {
            if ( field == null || fieldInfo == null ) return false;
            if ( fieldInfo.Name != nameof( CanCompress ) ) return false;

            //writer.Align(4, 0);
            writer.Write( 0xFEFEFEFE );
            return true;
        }
    }
}
