using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xBBE337CA5A46D965)]
    public class TkJointBindingData : ToolkitDataType {

        [NMS(Size = 16)]
        public float[] InvBindMatrix; // 4x4 matrix

        [NMS(Size = 3)]
        public float[] BindTranslate; // Vector3f

        [NMS(Size = 4)]
        public float[] BindRotate; // Quaternion

        [NMS(Size = 3)]
        public float[] BindScale; // Vector3f
    }
}
