using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main ( string [] args )
        {
            int count = 0;  // sentinel variable

            while ( count != 30 ) // condition to check
            {
                Console.WriteLine($"Playing count: {count}");
                count++;    //increment by 1
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please press any key to exit ...");
            Console.ReadKey();
        }
    }
}
