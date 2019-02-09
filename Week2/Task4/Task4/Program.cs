using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string newpath = @"C:\Users\aka-studio\Desktop\PP2\local";
            Creation(newpath);
        }
        public static void Creation(string newpath)
        {
            Directory.CreateDirectory(newpath);
            string filename = "FirstTimeGirl.txt";
            newpath = Path.Combine(newpath, filename);
            FileStream fs = File.Create(newpath);
            for (byte i = 0; i < 100; i++)
                fs.WriteByte(i);
            fs.Close();
            Copying(newpath);
            Deleting(newpath);
        }
        public static void Copying(string newpath)
        {
            string target = @"C:\Users\aka-studio\Desktop\PP2\LastTimeGirl.txt";
            File.Copy(newpath, target);
        }
        public static void Deleting(string newpath)
        {
            File.Delete(newpath);
        }
    }
}
