using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x1B43A3BABC81D6E8)]
    public class TkHitCurveData : ToolkitComponent {

        /* 0x000 */ public float Time;
		/* 0x004 */ public TkInOutCurve Curve;
    }
}