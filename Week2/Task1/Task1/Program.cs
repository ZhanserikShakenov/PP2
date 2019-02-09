using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
        }
        public static void Read()
        {
            StreamReader sR = new StreamReader("C:/Users/aka-studio/Desktop/PP2/PP2/Week2/Task1/Task1/input.txt");
            string s = sR.ReadToEnd();
            bool t = true;
            for(int i=0; i<s.Length/2; i++)
                if (s[i] != s[s.Length - i - 1])
                    t = false;
            if(t)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
