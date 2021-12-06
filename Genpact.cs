using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysInterface3
{
    class Genpact
    {
        public string information;
        public void PrintInformation()
        {
            Console.WriteLine("Enter the information : ");
            information = Console.ReadLine();
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"\nInformation of wipro : {information}\n");
        }
        
    }
}
