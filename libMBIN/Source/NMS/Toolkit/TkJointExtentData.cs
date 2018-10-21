using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x570DB1A0C98C0858)]
    public class TkJointExtentData : ToolkitComponent {

        [NMS(Size = 3)]
        public float[] JointExtentMin; // Vector3f

        [NMS(Size = 3)]
        public float[] JointExtentMax; // Vector3f

        [NMS(Size = 3)]
        public float[] JointExtentCenter; // Vector3f

        [NMS(Size = 3)]
        public float[] JointExtentStdDev; // Vector3f
    }
}
