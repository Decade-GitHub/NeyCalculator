using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace NeyCalcGUI
{
    class Messi : Player
    {
        public Messi()
        {
            this.parms = new PlayerParms()
            {
                Altura = 170,
                Massa = 72,
                Kilobytes = 157,
                Capacidade = 4,
                Temperatura = 36,
                Velocidade = 29
            };
            Init(parms, "Messi");
        }
    }
}