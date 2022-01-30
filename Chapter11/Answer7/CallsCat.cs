using System;
using System.Collections.Generic;
namespace Chapter11.Answer7
{
    public class CallsCat
    {
        public static void CallCatAnsSevenandEight()
        {
            string name= "Alfred";
            for(int i=0; i<10; i++)
            {
                Cat Alfred = new Cat(name+ Sequence.NextValue(), "yellow");

                Alfred.sayMiua();
            }   
           

        }
       
    }
}