﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x79BCF4E60FAC1B71)]
    public class GcAlienSpeechEntry : GameComponent {

        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;

        [NMS(Size = 0x20)]
        /* 0x10 */ public string Text;

        public enum WordInteractEffectEnum { Pain, Heal };
        /* 0x30 */ public WordInteractEffectEnum WordInteractEffect;

        /* 0x34 */ public GcAlienRace AlienRace;
        /* 0x38 */ public int Level;
        [NMS(Ignore = true)]
        public int EndPadding;
    }
}
