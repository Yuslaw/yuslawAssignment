using System;
using System.Collections.Generic;
namespace Chapter11.Answer7
{
    public class Sequence
    {
        private static int currentValue = 0;

        private Sequence()
        {

        }
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
        
    }
}