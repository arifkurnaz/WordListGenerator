using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhbkExceptionGrabber
{
    public static class ExceptionGlobals
    {
        private static string _exceptionPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Ahbk SoftTech\logs";
        private static string _errorLog = "error.log";
        private static string _accesLog = "acces.log";
        private static string _errorDetailLog = "errorDetail.log";
        private static string _runTimeLog = "runtime.log";
        private static string _settingPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Ahbk SoftTech\Settings";
        private static string _settingFile = "settings.ini";
        private static string _xmlFile = "settings.xml";

        public static string ExceptionPath
        {
            get
            {
                return _exceptionPath;
            }

            set
            {
                _exceptionPath = value;
            }
        }

        public static string ErrorLog
        {
            get
            {
                return _errorLog;
            }

            set
            {
                _errorLog = value;
            }
        }

        public static string AccesLog
        {
            get
            {
                return _accesLog;
            }

            set
            {
                _accesLog = value;
            }
        }

        public static string RunTimeLog
        {
            get
            {
                return _runTimeLog;
            }

            set
            {
                _runTimeLog = value;
            }
        }

        public static string SettingPath
        {
            get
            {
                return _settingPath;
            }

            set
            {
                _settingPath = value;
            }
        }

        public static string SettingFile
        {
            get
            {
                return _settingFile;
            }

            set
            {
                _settingFile = value;
            }
        }

        public static string XmlFile
        {
            get
            {
                return _xmlFile;
            }

            set
            {
                _xmlFile = value;
            }
        }

        public static string ErrorDetailLog
        {
            get
            {
                return _errorDetailLog;
            }

            set
            {
                _errorDetailLog = value;
            }
        }
    }
}
