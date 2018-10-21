using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x181752F0C2DF5722)]
    public class GcCameraSpawnSetupData : GameComponent {

		/* 0x000 */ public float Distance;              // 41A00000h
		/* 0x004 */ public bool InFrontOfShip;          // 0
		/* 0x008 */ public float YawProportion;         // 3FE66666h
		/* 0x00C */ public float HorizontalProportion;  // 40C00000h
	}
}