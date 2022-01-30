using System;
using System.Collections.Generic;

namespace Chapter11.Answer4
{
    public class Answer4
    {
        public static void AnsFour()
        {
            int tickCount = 0;
            DateTime now = DateTime.UtcNow;
            DateTime StartComputer = now - TimeSpan.FromMilliseconds(Environment.TickCount);
            Console.WriteLine(StartComputer + TimeSpan.FromMilliseconds(tickCount));
        }
        
    }
}