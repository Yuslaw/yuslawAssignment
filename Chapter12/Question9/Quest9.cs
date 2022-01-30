using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter12
{
    public class Quest9
    {
        public static void AnsThree()
        {
            try
            {
                using (StreamReader read = new StreamReader("textFile.txt"))
            {
               string file = "C:\\Users\\USER\\Desktop\\SolelyAssignments\\Chapter12\\Question9\\textFile.txt";
                string line = read.ReadToEnd();
                Console.WriteLine(line);
            }

            }
            catch(Exception e)
            {
                Console.WriteLine("The file cannot be read:");
                Console.WriteLine(e.Message);
            }
        }
        
        
    }
}