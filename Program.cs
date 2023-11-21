using System;
using System.IO;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace NeyCalcGUI
{
    class Master
    {
        private string? UserValue;
        private int UserUnit;

        const int AlturaNeymar = 175;
        const int MassaNeymar = 63;
        const int CapacidadeNeymar = 5;
        const int KilobytesNeymar = 206;
        const int VelocidadeNeymar = 30;
        const int TemperaturaNeymar = 37;
        public static float Calculate(float UV, int UU)
        {
            return UU switch
            {
                0 => UV / AlturaNeymar,
                1 => UV / MassaNeymar,
                2 => UV / CapacidadeNeymar,
                3 => UV / KilobytesNeymar,
                4 => UV / VelocidadeNeymar,
                5 => UV/ TemperaturaNeymar,
                _ => throw new InvalidDataException("Tu é burro, irmão?")
            };
        }
    }
}