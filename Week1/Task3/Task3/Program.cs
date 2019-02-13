using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                          //declare size of array and input
            string[] s = Console.ReadLine().Split();                        //input elements of array
            int[] a = new int[n];                                           //declare array
            for(int i=0; i<n; i++)                                          
            {                                                               
                a[i] = int.Parse(s[i]);                                     //convert to int then add to array
                //Console.Write(((a[i])-(1/2)+Math.Pow(-1,a[i])*(1/2))/2);
                Console.WriteLine(Math.Pow(2, 3));
                //output double each element
            }
            Console.ReadKey();
        }
    }
}
