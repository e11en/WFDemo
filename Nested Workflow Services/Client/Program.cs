using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string to process:");
            var input = Console.ReadLine();
            var service = new UpperCaseService.UpperCaseStringClient();
            Console.WriteLine("Output from service: {0}", service.ReverseString(input));
            Console.ReadKey();
        }
    }
}
