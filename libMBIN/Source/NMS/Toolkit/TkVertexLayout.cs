using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xB5F73B43F19328BA)]
    public class TkVertexLayout : ToolkitDataType {

        public int ElementCount;
        public int Stride;

        [NMS(Size = 8)]
        public string PlatformData;       // this *should* be a long, but nothing seems to use it, so we'll just leave it as a string of length 8...

        public List<TkVertexElement> VertexElements;
    }
}
