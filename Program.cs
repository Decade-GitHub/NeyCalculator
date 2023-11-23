using System;

namespace NeyCalcGUI
{
    class Master
    {
        public static PlayerResult Calculate(float UV, int UU, int PV)
        {
            Neymar n = new();
            Messi m = new();
            
            return PV switch
            {
                0 => n.Calculate(UV, UU),
                1 => m.Calculate(UV, UU),
                _ => throw new Exception("This is impossible."),
            };
        }
        public static PlayerResult FetchResultType(int UU, int PV)
        {
            Neymar n = new();
            Messi m = new();

            return PV switch
            {
                0 => n.FetchResultType(UU),
                1 => m.FetchResultType(UU),
                _ => throw new Exception("This is impossible.")
            };
        }
    }
}
