using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x89ED051FD49328DB)]
    public class GcShipHUDTargetIconData : GameComponentType {

        [NMS(Size = 0x80)]
        public string Corner;
        [NMS(Size = 0x80)]
        public string LineHorizontal;
        [NMS(Size = 0x80)]
        public string LineVertical;

        [NMS(Size = 0x80)]
        public string GlowCorner;
        [NMS(Size = 0x80)]
        public string GlowLineHorizontal;
        [NMS(Size = 0x80)]
        public string GlowLineVertical;
    }
}
