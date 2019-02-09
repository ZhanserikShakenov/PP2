using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\aka-studio\Desktop\PP2\PP2\Week2\Task2\Task2/input.txt");
            string[] s = sr.ReadToEnd().Split();
            StreamWriter sw = new StreamWriter(@"C:\Users\aka-studio\Desktop\PP2\PP2\Week2\Task2\Task2/output.txt");
            for(int i=0; i<s.Length; i++)
                if (Aprime(int.Parse(s[i])))
                {
                    sw.Write(s[i] + " ");
                }
            sw.Close();
        }
        public static bool Aprime(int num)
        {
            if (num == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num%i==0)
                    return false;
            return true;
        }
    }
}
