﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x24AFDEE56923EAD3)]
    public class GcPersistentTerrainEdits : GameComponentType {

        public ulong GalacticAddress;
        public List<int> BufferSizes;
        public List<Vector4f> BufferAnchors;
        public List<GcTerrainEdit> Edits;       // just a guess... Don't think any structs use this...
    }
}
