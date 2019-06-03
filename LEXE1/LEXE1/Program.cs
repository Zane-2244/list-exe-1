using System;
using System.Collections.Generic;

namespace LEXE1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter diffrent names: ");
               var name = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("A sertan amount of names have been Entered ");
                    continue;
                }
                break;
               
            }
        }
    }
}
