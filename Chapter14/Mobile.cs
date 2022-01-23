using System;
using System.Collections.Generic;
namespace Chapter14
{
    //Question 8,9,10,11, 12
    public class Mobile: Call
    {
        public string Model;
        public string Manufacturer;
        public string Owner;
        public float Price;
        //question 11
        public BatteryType Batteryy;
        //question 10
        private static string NokiaN95;
        //question 13
        private string Imei {get; set;}
       public List<string> l1 = new List<string>();
        
        Mobile nokia = new Mobile("nokiaN95", "nokia", "ade", 19f, DateTime.Now, "09:00 am- 10-00am", TimeSpan.Zero);
         
       
        public void Setnokia(string nokiaN95)
        {
            NokiaN95 = nokiaN95;
        }
        

         public string GetNokia()
        {
            return NokiaN95;
        }
       
        public Mobile(string model, string manufacturer, string owner, float price, DateTime time, string timestart, TimeSpan duration): base(time, timestart, duration)
        {
            Model= model;
            Manufacturer = manufacturer;
            Owner = owner;
            Price = price;
            
        }
       

             //question 12
           public override string ToString()
        {
            return $"The model of phone is {Model}, the manufactuerer is {Manufacturer}, the owner is {Owner}, the price is {Price} and the is {Batteryy} ";
        }

       

         
     
        
    }
    
    

    public class Battery
    {
         public string BatteryModel;
        public int BatteryIdleTime;

        public int HourTalk;
        //question 13
        private string Type {get; set;}

        public Battery(string batteryModel, int batteryIdleTime, int hourTalk)
        {
            BatteryModel =batteryModel;
            BatteryIdleTime = batteryIdleTime;
            HourTalk = hourTalk;
        }
    }

    public class Screen
    {
        
        public int Size;
        public string Colour;
        //question 13
        private string shape {get; set;}

    
        public Screen(int size, string colour)
        {
            Size = size;
            Colour = colour;
        }

   
    }

        //question 14
    public class MobileTest: Mobile
    {
        public MobileTest(string model, string manufacturer, string owner, float price, DateTime time, string timestart, TimeSpan duration): base(model, manufacturer, owner, price, time, timestart, duration)
        {

        }
        public void Printinfo()
        {
            string[] arr = { Model, Manufacturer, Owner, Price.ToString()};
            GetNokia();
            
        }

    }
    
}