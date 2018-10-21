﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x55A2F338BBCB7BA)]
    public class TkNGuiEditorLayout : ToolkitDataType {

        [NMS(Size = 0x100)]
        public TkNGuiWindowLayoutData[] Windows;
    }
}
