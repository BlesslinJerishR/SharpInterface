using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysInterface3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft");
            MS ms = new MS();
            ms.PrintInformation();
            ms.DisplayInformation();
            ms.Bonjour();

            Console.WriteLine("Wipro");
            Wipro ow = new Wipro();
            ow.PrintInformation();
            ow.DisplayInformation();

            Console.WriteLine("Genpact");
            Genpact og = new Genpact();
            og.PrintInformation();
            og.DisplayInformation();

            //Don't delete
            Console.ReadLine();
        }
    }
}


