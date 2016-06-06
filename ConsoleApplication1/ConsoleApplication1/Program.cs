using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            double n = double.Parse(Console.ReadLine());
            if (n < 1)
                Console.WriteLine("baby");
            else if (n >= 1 && n <= 11)
                Console.WriteLine("child");
            else if (n >= 12 && n <= 15)
                Console.WriteLine("teenager");
            else if (n >= 16 && n <= 25)
                Console.WriteLine("youth");
            else if (n >= 26 && n <= 70)
                Console.WriteLine("man");
            if (n > 70)
                Console.WriteLine("old");
            
 
            Console.ReadKey(true);
           
        

        }
    }
}
