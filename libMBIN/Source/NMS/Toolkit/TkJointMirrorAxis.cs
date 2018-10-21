using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x11E5EDDC4A44DF65)]
    public class TkJointMirrorAxis : ToolkitData {

        public float TransMirrorAxisX;
        public float TransMirrorAxisY;
        public float TransMirrorAxisZ;

        public float RotAdjustX;
        public float RotAdjustY;
        public float RotAdjustZ;
        public float RotAdjustW;

        public float RotMirrorAxisX;
        public float RotMirrorAxisY;
        public float RotMirrorAxisZ;

        public int MirrorAxisMode;
    }
}
