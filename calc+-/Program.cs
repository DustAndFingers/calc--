using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Складываем первое число:");
            string plusfirst = Console.ReadLine();
            int plusfirs;
            plusfirs = Convert.ToInt32(plusfirst);
            Console.WriteLine("Складываем второе число:");
            string plussecond = Console.ReadLine();
            int plussecon;
            plussecon = Convert.ToInt32(plussecond);
            Plus Slojenie = new Plus();
            int resultPlus = Slojenie.plus(plusfirs, plussecon);
            Console.WriteLine("\n результат сложения:" + resultPlus);
            Console.ReadKey();


        }
    }
}
