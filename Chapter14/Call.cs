using System;
using System.Collections.Generic;
namespace Chapter14
{
    //question 15
         public class Call: Ccgsm
    {
       
        public DateTime Time {get; set;} 
        public string TimeStart { get; set; }
        public TimeSpan Duration { get; set; }
        
        List<int> callHistory = new List<int>();

         public Call(DateTime time, string timeStart, TimeSpan duration)
        {
            Time = time;
            TimeStart = timeStart;
            Duration = duration;
            Conversation();
            TotalAmountOfCall(19f);
        }
        

          public string GetTime()
        {
            var y = Time + " " + TimeStart + " " + Duration;
            return y;
            
        }

        public int Conversation()
        {
            int callhistroy1 = DateTime.DaysInMonth(2020, 09);
            int callhistroy2 = DateTime.DaysInMonth(2020, 10);
            int callhistroy3 = DateTime.DaysInMonth(2021, 01);
            callHistory.Add(callhistroy1);
            callHistory.Add(callhistroy2);
            callHistory.Add(callhistroy3);
            int all = callhistroy1+ callhistroy2 + callhistroy3;
            return all;
        }   
        //question 17
        public void Deletecalls(int call)
        {
              foreach (var item in callHistory)
            {
                if(item == call)
                {
                    callHistory.Remove(item);
                }
                
            }
            
            
        }

         //question 18
        public void TotalAmountOfCall(float price)

        {
            price = 19f;
            
            var total= Conversation()*price;
            Console.WriteLine($"totalamount is {total}");

        }

    }

    public class Gener<T> where T: Ccgsm
    {
        public string GetTimeUpper(T obj)
        {
            return obj.GetTime();
        }

      
    }
}