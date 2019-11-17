using System;
using System.IO;

namespace time_logger
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool endApp = false;

            Logger a = new Logger();

            while (!endApp)
            {       
                try 
                {
                    DateTime locaDate = DateTime.Now;
                    a.Log(locaDate.ToString());
                    a.saveLog(locaDate.ToString());
                }

                catch (Exception e)
                {
                    Console.WriteLine("THere's been an issue", e.ToString());
                }

                if (Console.ReadLine() == "n") endApp = true;
            }

        }
    }
}

class Logger {
    private string fileName = "log.txt";
    static string path = Directory.GetCurrentDirectory(); 
    static string pathName;
    public Logger ()
    {
        pathName = path + "\\" + fileName;
    }

    public void setFileName (string name)
    {
        fileName = name;
    }

    public void Log (string str)
    {
        Console.WriteLine(str);
    }

    public void saveLog (string localDateTime)
    {
        using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(pathName, true))
        {
            file.WriteLine(localDateTime);
        }
    }
}