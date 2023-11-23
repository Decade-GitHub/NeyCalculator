using System;
using System.IO;

namespace NeyCalcGUI
{
    public abstract class Player
    {
        public PlayerParms? parms;
        public string? PlayerName;
        public void Init(PlayerParms? parms, string? PN)
        {
            this.parms = parms;
            PlayerName = PN;
        }
        public PlayerResult Calculate(float UV, int UU)
        {
            return new PlayerResult()
            {
                ResultValue = CalculateValue(UV, UU)
            };
        }
        private float CalculateValue(float UV, int UU)
        {
            if (parms == null) throw new Exception("This is impossible.");
            
            return UU switch
            {
                0 => UV / parms.Altura,
                1 => UV / parms.Massa,
                2 => UV / parms.Capacidade,
                3 => UV / parms.Kilobytes,
                4 => UV / parms.Velocidade,
                5 => UV / parms.Temperatura,
                _ => throw new InvalidDataException("Tu é burro, irmão?")
            };
        }
        public PlayerResult FetchResultType(int UU)
        {
            return UU switch
            {
                0 => new PlayerResult()
                {
                    ResultType = $"{PlayerName}meters"
                },
                1 => new PlayerResult()
                {
                    ResultType = $"{PlayerName}kilos"
                },
                2 => new PlayerResult()
                {
                    ResultType = $"{PlayerName}liters"
                },
                3 => new PlayerResult()
                {
                    ResultType = $"{PlayerName}kilobytes"
                },
                4 => new PlayerResult()
                {
                    ResultType = $"{PlayerName}kilometers per hour"
                },
                5 => new PlayerResult()
                {
                    ResultType = $"{PlayerName}celsius"
                },
                _ => throw new Exception("This is impossible."),
            };
        }
    }
}