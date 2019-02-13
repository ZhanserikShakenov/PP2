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
            string newpath = @"C:\Users\aka-studio\Desktop\PP2\local";                  //create string which consist path
            Creation(newpath);                                                          //call function for create
        }
        public static void Creation(string newpath)
        {
            Directory.CreateDirectory(newpath);                                         //create new directory
            string filename = "FirstTimeGirl.txt";                                      //say our new file will be FirstTimeGirl
            newpath = Path.Combine(newpath, filename);                                  //combine direction and name
            FileStream fs = File.Create(newpath);                                       //create file and create filestream for write come symbols
            for (byte i = 0; i < 100; i++)
                fs.WriteByte(i);
            fs.Close();                                                                 //close for saving
            Copying(newpath);                                                           //call function which copied
            Deleting(newpath);                                                          //call function which deleted
        }
        public static void Copying(string newpath)
        {
            string target = @"C:\Users\aka-studio\Desktop\PP2\LastTimeGirl.txt";        //target path
            File.Copy(newpath, target);                                                 //copying from source newpath to target path
        }
        public static void Deleting(string newpath)                                     
        {
            File.Delete(newpath);                                                       //delete first file
        }
    }
}
