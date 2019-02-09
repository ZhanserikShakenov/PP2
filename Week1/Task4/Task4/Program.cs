using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                   //input StarTriangle size
            for (int i = 0; i < n; i++)                              
            {                                                        
                for (int c = 0; c <= i; c++)                         
                    Console.Write("[*]");                            //output the star cyclically
                Console.WriteLine();
            }
            //Console.ReadKey();
        }
    }
}
