using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\aka-studio\source\repos";                    //create string which consist path
            Show(path, 0);                                                        //call show function
        }
        public static void Level(int level)                                       //function space for illustration
        {
            for (int i = 0; i < level; i++)
                Console.Write(" ");
        }
        public static void Show(string path, int level)
        {
            DirectoryInfo directory = new DirectoryInfo(path);                    //create directoryinfo with direction of our path
            FileSystemInfo[] files = directory.GetFileSystemInfos();              //get files and add to array
            foreach(FileSystemInfo file in files)                                 //consider each file
            {
                Level(level);                                                     //consider for descent
                Console.WriteLine(file.Name);                                     //write name of file
                if (file.GetType() == typeof(DirectoryInfo))                      //if it directory open and show all consistance
                    Show(file.FullName, level + 1);
            }
        }
    }
}
