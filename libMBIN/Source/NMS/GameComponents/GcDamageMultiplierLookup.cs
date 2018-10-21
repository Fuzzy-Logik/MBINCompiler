using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xA829A15F1ECEF45B)]
    public class GcDamageMultiplierLookup : GameComponent {


        [NMS(Size = 0x10)]
        public string Id;
        public float Default;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding14;
        public List<GcDamageMultiplier> Multipliers;
    }
}