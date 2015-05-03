using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public static class LogHelper
    {
        public static void Log(Exception ex)
        {
            Log(ex.ToString());
        }

        public static void Log(string message)
        {
            if (!Directory.Exists("Log"))
            {
                Directory.CreateDirectory("Log");
            }
            var fileName = string.Format("Log/{0}.txt", DateTime.Now.ToString("yyyy-MM-dd"));
            var logMsg = string.Format("{0}:{1}\r\n", DateTime.Now.ToString(), message);
            if (File.Exists(fileName))
            {
                File.AppendAllText(fileName, logMsg);
            }
            else
            {
                File.WriteAllText(fileName, logMsg);
            }
        }
    }
}
