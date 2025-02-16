using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSolution3
{
    internal class Logger
    {
        public string Path { get; set; }
        public DateTime DateTime { get; set; }


        public Logger(string path, DateTime dateTime)
        {
            Path = path;
            DateTime = dateTime;
        }

        public void Log()
        {
            string newNamePath = CreateNameFolder(DateTime.ToString());
            CreateFolder(newNamePath);

            while (true)
            {
                DateTime work = DateTime.Now;
                if (DateTime <= work.AddMinutes(-1))
                {
                    newNamePath = CreateNameFolder(work.ToString());
                    CreateFolder(newNamePath);
                    DateTime = DateTime.AddMinutes(1);
                }
                CreateFile(newNamePath);

                Thread.Sleep(TimeSpan.FromSeconds(10));
            }

        }

        public bool IsCheckFolder(string path)
        {
            return Directory.Exists(path);
        }

        public string CreateNameFolder(string pathNewTime)
        {
            string timeWorkFolder = pathNewTime.Replace(":", "-");
            return Path + timeWorkFolder;
        }


        public void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void CreateFile(string path)
        {
            string newNameFile = DateTime.Now.ToString().Replace(":", "-");
            string pathFile = path + $"/test{newNameFile}.txt";
            using (var streamWriter = new StreamWriter(pathFile, true))
            {
                streamWriter.WriteLine(newNameFile);
            }
        }
    }
}
