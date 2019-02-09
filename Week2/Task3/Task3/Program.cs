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
            string path = @"C:\Users\aka-studio";
            Show(path, 0);
        }
        public static void Level(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write(" ");
        }
        public static void Show(string path, int level)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] files = directory.GetFileSystemInfos();
            foreach(FileSystemInfo file in files)
            {
                Level(level);
                Console.WriteLine(file.Name);
                if (file.GetType() == typeof(DirectoryInfo))
                    Show(file.FullName, level + 1);
            }
        }
    }
}
