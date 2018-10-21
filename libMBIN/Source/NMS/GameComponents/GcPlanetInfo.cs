﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x382, GUID = 0x7848EDF863AB4294)]
    public class GcPlanetInfo : GameComponentType {

        [NMS(Size = 0x80)]
        public string PlanetDescription;
        [NMS(Size = 0x80)]
        public string PlanetType;
        [NMS(Size = 0x80)]
        public string Weather;
        [NMS(Size = 0x80)]
        public string Resources;
        [NMS(Size = 0x80)]
        public string Flora;
        [NMS(Size = 0x80)]
        public string Fauna;
        [NMS(Size = 0x80)]
        public string Sentinels;

        public bool IsWeatherExtreme;
        public bool AreSentinelsExtreme;
    }
}
