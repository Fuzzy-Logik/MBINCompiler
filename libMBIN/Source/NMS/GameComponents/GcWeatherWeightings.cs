﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3694978110105288)]
    public class GcWeatherWeightings : GameComponent {

        [NMS(Size = 10, EnumValue = new string[10] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive", "RedWeather", "GreenWeather", "BlueWeather" })]
        /* 0x380 */ public float[] WeatherWeightings;
    }
}
