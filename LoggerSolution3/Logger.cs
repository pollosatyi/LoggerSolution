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
        public DateTime dateTime { get; set; }

        public Logger(string path)
        {
            Path = path;
        }

        public void Log()
        {

        }

        public bool IsCheckFolder()
        {
            return Directory.Exists(Path);
        }



        public void CreateFolder()
        {
            Directory.CreateDirectory(Path);
        }

        private void CreateFile()
        {
            using (var streamWriter = new StreamWriter(Path, true))
            {
                streamWriter.Write("");
            }
        }
    }
}
