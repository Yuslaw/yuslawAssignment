using System;
using System.Collections.Generic;
namespace Chapter11.Answer11
{
    public class Answer11
    {
         public static void AnsEleven()
         {
             Random rand = new Random();
             string [] firstName = new string []{"Dayan", "Stella", "Hellen", "Ishola", "Kate"};
             string [] lastName = new string []{"Johnson", "Peterson", "Ade", "Charls"};
             string [] cities = new string []{"London", "Berlin", "Paris", "New York", "Madrid"};
             string []Laudatoryphrases = new string []{"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
             string []  Laudatorystories = new string []{"Now I feel better.", "I managed to change.", "It made some miracle.", "I cant believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};

             Console.WriteLine(Laudatoryphrases[rand.Next(4)],  Laudatorystories[rand.Next(5)], firstName[rand.Next(5)], lastName[rand.Next(4)], cities[rand.Next(5)]);
         }
        
    }
}