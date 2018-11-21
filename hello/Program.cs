using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];

            Console.WriteLine("Witaj," + name);

            Console.WriteLine("Witaj świecie");

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj  " + item);
            //}

        }
    }
}
