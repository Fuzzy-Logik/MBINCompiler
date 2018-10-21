using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x3AEA123B35FF91D2)]
    public class TkInOutCurve : ToolkitData {

        /* 0x000 */ public float Midpoint;
		/* 0x004 */ public TkCurveType InCurve;
		/* 0x008 */ public TkCurveType OutCurve;
    }
}