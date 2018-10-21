﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9C7856897DF694E5)]
    public class GcHUDComponent : GameComponent {

        [NMS(Size = 0x10)]
        public string Id;

        public int PosX;
        public int PosY;
        public int Width;
        public int Height;
		public enum AlignEnum { Center, TopLeft, TopRight, BottomLeft, BottomRight }
		public AlignEnum Align;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
