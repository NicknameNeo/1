using System;

namespace practic
{
    class Program
    {
        static double Nain()
        
        {
            var a = Convert.ToInt32(Console.ReadLine());
            
            if (a % 2 == 0)
            {
                Console.WriteLine("Chetnoe");
            }
            else
            {
                Console.WriteLine("Nechetnoe");
            }
            return a;
        }

    static void Main(string[] args)
        {
            Console.WriteLine(Nain());
            Console.WriteLine(Nain());
            Console.WriteLine(Nain());
            Console.WriteLine(Nain());
            Console.WriteLine(Nain());
            
            
        }
    }
}