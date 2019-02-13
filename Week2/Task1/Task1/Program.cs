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
            StreamReader sR = new StreamReader("C:/Users/aka-studio/Desktop/PP2/PP2/Week2/Task1/Task1/input.txt");//create reader which read a file.txt
            string s = sR.ReadToEnd();                                                                            //read a text file
            bool t = true;                                                                                        //create boolean for check
            for(int i=0; i<s.Length/2; i++)     
                if (s[i] != s[s.Length - i - 1])                                                                  //check for polindrom or not
                    t = false;
            if(t)                                                                                                 //if yes write yes
                Console.WriteLine("YES");
            else                                                                                                  //else write no
                Console.WriteLine("NO");
        }
        
    }
}
