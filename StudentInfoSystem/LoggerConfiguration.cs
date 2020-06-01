using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class LoggerConfiguration
    {
        static public string LogFile
        {
            get => "logs.txt";
            private set { }
        }

        static public string AttemptsLogFile
        {
            get => "att.json";
            private set { }
        }

    }
}
