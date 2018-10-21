﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x130, Alignment = 0x10, GUID = 0xC8A70377D08EA4)]
    public class GcMaintenanceComponentData : GameComponent {

        /* 0x000 */ public List<GcMaintenanceElement> PreInstalledTech;
        /* 0x010 */ public int VisibleMaintenanceSlots;
        /* 0x014 */ public bool AllowRepair;
        /* 0x015 */ public bool AllowCharge;
        /* 0x016 */ public bool AllowDismantle;
        /* 0x017 */ public bool AllowInstallTech;
        /* 0x018 */ public bool AllowCraftProduct;
        /* 0x019 */ public bool AllowTransfer;
        /* 0x01A */ public bool AllowMoveAndStack;
        /* 0x01B */ public bool AllowTransferIn;
        /* 0x01C */ public bool AutoCompleteOnStart;
        /* 0x01D */ public bool UseModelResourceRenderer;
        /* 0x01E */ public bool UseBoundsForIconCentre;

		public enum InteractableEnum { OnlyWhenComplete, OnlyWhenNotComplete, Always, Never }
		public InteractableEnum Interactable;

        /* 0x024 */ public float CompletedTransitionDelay;
        /* 0x028 */ public bool ShareInteractionModelRender;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x02C */ public byte[] Padding2C;

        /* 0x030 */ public TkModelRendererData ModelRendererData;

		public enum ModelRendererResourceEnum { ModelNode, MasterModelNode }
		public ModelRendererResourceEnum ModelRendererResource;

        /* 0x0E4 */ public GcBroadcastLevel BroadcastLevel;

        [NMS(Size = 0x20)]
        /* 0x0E8 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x108 */ public string Description;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x128 */ public byte[] EndPadding;
    }
}
