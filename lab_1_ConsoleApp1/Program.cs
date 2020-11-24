using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入名字:");
            string Name = Console.ReadLine();
            Console.WriteLine("Hi C# ! "+ Name );
            Console.ReadKey();
        }
    }
}
