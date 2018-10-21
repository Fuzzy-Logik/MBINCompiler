﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA9410B6550F62352)]
    public class GcWeatherOptions : GameComponent {

		public enum WeatherEnum { Clear, Dust, Humid, Snow, Toxic, Scorched, Radioactive, RedWeather, GreenWeather, BlueWeather }
		public WeatherEnum Weather;
    }
}
