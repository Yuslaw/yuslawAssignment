using System;
using System.Collections.Generic;
namespace Chapter11.Answer7
{
    public class Cat
    {
        private string Name;
        private string Colour;

        public Cat(string name, string colour)
        {
            Name=name;
            Colour=colour;
        }

        public void sayMiua()
        {
            Console.WriteLine($"Miua, {Name}");
        }

        
    }
}