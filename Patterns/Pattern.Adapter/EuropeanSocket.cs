using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Adapter
{
    public class EuropeanSocket
    {
        public void Provide220Volts()
        {
            Console.WriteLine("Подаётся 220V, штыри круглые.");
        }
    }
}
