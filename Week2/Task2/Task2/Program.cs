﻿using System;
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
            StreamReader sr = new StreamReader(@"C:\Users\aka-studio\Desktop\PP2\PP2\Week2\Task2\Task2/input.txt"); //create reader
            string[] s = sr.ReadToEnd().Split();                                                                    //read a text file
            StreamWriter sw = new StreamWriter(@"C:\Users\aka-studio\Desktop\PP2\PP2\Week2\Task2\Task2/output.txt");//create writer
            for(int i=0; i<s.Length; i++)
                if (Aprime(int.Parse(s[i])))                                                                        //check for prime
                {
                    sw.Write(s[i] + " ");                                                                           //if yes write yes
                }
            sw.Close();                                                                                             //and close for ending and saving
        }
        public static bool Aprime(int num)                                                                          //boolean function for check
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
