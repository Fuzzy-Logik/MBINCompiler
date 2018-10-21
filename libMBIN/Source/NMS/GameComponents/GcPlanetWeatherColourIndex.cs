﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4DA6EA7EB1532236)]
    public class GcPlanetWeatherColourIndex : GameComponent {

		public enum WeatherColourSetEnum { Common, Rare }
		public WeatherColourSetEnum WeatherColourSet;
        public int Index;
    }
}
