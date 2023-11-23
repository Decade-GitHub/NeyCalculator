using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace NeyCalcGUI
{
    class Neymar : Player
    {
        public Neymar()
        {
            this.parms = new PlayerParms()
            {
                Altura = 175,
                Massa = 68,
                Kilobytes = 206,
                Capacidade = 5,
                Temperatura = 37,
                Velocidade = 30
            };
            Init(parms, "Ney");
        }
    }
}