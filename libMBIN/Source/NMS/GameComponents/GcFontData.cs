using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9F99427CD6CB8D5C)]
	public class GcFontData : GameComponentType {

		[NMS(Size = 0x80)]
		public string File;
		public int MinCharWidth;
	}
}
