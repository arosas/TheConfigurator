using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheConfigurator
    ;

namespace ConfiguratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Encrpyion");

            var test = Config.Encrpyt("This is a test!");


            Console.WriteLine("Encrpyted String : "+ test);


            Console.WriteLine($"Unencrpyted Text  :"+Config.Decrypt(test));

            Console.ReadLine();


        }
    }
}
