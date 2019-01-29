using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());             //declare size of array
            string[] s = Console.ReadLine().Split();                 //input array
            int a = 0;                                               //declare counter
            List<int> Aprime = new List<int>();                      //declare simplest list of similar objects
            for (int i = 0; i < n; i++)                              
                if (Prime(int.Parse(s[i])))                          //check for a prime number
                {                                                    
                    ++a;                                             //if number prime, add 1 for counter
                    Aprime.Add(int.Parse(s[i]));                     //if number prime, add number in list
                }                                                    
            Console.WriteLine(a);                                    //amount of prime numbers
            foreach(int i in Aprime)                                 //output each number from the list
                Console.Write(i + " ");                              
            Console.ReadKey();                                       
        }                                                            
        static bool Prime(int x)                                     
        {                                                            
            if (x == 1) return false;                                //1 isn't prime
            for (int i = 2; i <= Math.Sqrt(x); i++)                  //use math and check for prime
                if (x % i == 0)
                    return false;
            return true;
        }
    }
}
