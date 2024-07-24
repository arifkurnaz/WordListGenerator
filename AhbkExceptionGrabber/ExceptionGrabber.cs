using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace AhbkExceptionGrabber
{
    public class ExceptionGrabber
    {
        DateTime dt = DateTime.Now;
        private bool check;



        private void CreateFile()
        {
            List<string> dosyalar = new List<string>();

            string[] isimler = {
ExceptionGlobals.ErrorLog,ExceptionGlobals.ErrorDetailLog,ExceptionGlobals.RunTimeLog,ExceptionGlobals.AccesLog

            };
            foreach (var item in isimler)
            {
                dosyalar.Add(ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + item);
            }
            foreach (var item in dosyalar)
            {
                if (File.Exists(item) == false)
                {
                    File.Create(item).Close();
                }
            }

        }
        private bool CreateFolder()
        {

            if (!File.Exists(ExceptionGlobals.ExceptionPath))
            {
                try
                {
                    Directory.CreateDirectory(ExceptionGlobals.ExceptionPath);
                    this.check = true;
                }
                catch (IOException)
                {
                    this.check = false;

                }
            }
            else
            {
                this.check = true;
            }
            return this.check;
        }
        private bool CheckFile(int logType)
        {
            string file;
            switch (logType)
            {
                case 1:
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }
                    break;
                case 2:
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.AccesLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }
                    break;
                case 3:
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.RunTimeLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }
                    break;
                case 4:
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }
                    break;
            }
            return this.check;

        }
        private bool CreateFile(int logType)
        {
            string file;
            switch (logType)
            {
                case 1:
                    File.Create(ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorLog).Close();
                    File.Create(ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog).Close();
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }

                    break;
                case 2:
                    File.Create(ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.AccesLog).Close();
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.AccesLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }
                    break;
                case 3:
                    File.Create(ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.RunTimeLog).Close();
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.RunTimeLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }
                    break;
                case 4:
                    File.Create(ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog).Close();
                    file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog;
                    if (File.Exists(file))
                    {
                        this.check = true;
                    }
                    else
                    {
                        this.check = false;
                    }
                    break;
            }
            return this.check;
        }
        public void LogWrite(string message, int logType)
        {

            string file;
            if (this.CreateFolder())
            {
                switch (logType)
                {
                    case 1:
                        if (CheckFile(1))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                            Dosya.Close();
                        }
                        else
                        {
                            CreateFile(1);

                            Thread.Sleep(100);
                            if (CheckFile(1))
                            {
                                file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorLog;
                                StreamWriter Dosya = File.AppendText(file);
                                Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                                Dosya.Close();



                            }
                        }
                        break;
                    case 2:
                        if (CheckFile(2))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.AccesLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                            Dosya.Close();
                        }
                        else
                        {
                            CreateFile(2);
                            Thread.Sleep(100);
                            if (CheckFile(2))
                            {
                                file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.AccesLog;
                                StreamWriter Dosya = File.AppendText(file);
                                Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                                Dosya.Close();
                            }
                        }
                        break;
                    case 3:
                        if (CheckFile(3))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.RunTimeLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                            Dosya.Close();
                        }
                        else
                        {
                            CreateFile(3);
                            Thread.Sleep(100);
                            if (CheckFile(3))
                            {
                                file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.RunTimeLog;
                                StreamWriter Dosya = File.AppendText(file);
                                Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                                Dosya.Close();
                            }
                        }
                        break;
                    case 4:
                        if (CheckFile(4))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                            Dosya.Close();
                        }
                        else
                        {
                            CreateFile(4);
                            Thread.Sleep(100);
                            if (CheckFile(4))
                            {
                                file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog;
                                StreamWriter Dosya = File.AppendText(file);
                                Dosya.WriteLine(DateTime.Now.ToString() + "==>" + message);
                                Dosya.Close();
                            }
                        }
                        break;
                }

            }
            else
            {
                CreateFolder();
                switch (logType)
                {
                    case 1:
                        if (CheckFile(1))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        else
                        {
                            CreateFile(1);
                            Thread.Sleep(100);
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        break;
                    case 2:
                        if (CheckFile(2))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.AccesLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        else
                        {
                            CreateFile(2);
                            Thread.Sleep(100);
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.AccesLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        break;
                    case 3:
                        if (CheckFile(3))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.RunTimeLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        else
                        {
                            CreateFile(3);
                            Thread.Sleep(100);
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.RunTimeLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        break;
                    case 4:
                        if (CheckFile(4))
                        {
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        else
                        {
                            CreateFile(4);
                            Thread.Sleep(100);
                            file = ExceptionGlobals.ExceptionPath + @"\" + String.Format("{0:MM/dd/yyyy}", dt) + "-" + ExceptionGlobals.ErrorDetailLog;
                            StreamWriter Dosya = File.AppendText(file);
                            Dosya.WriteLine(message);
                        }
                        break;
                }
            }

        }
    }
}
