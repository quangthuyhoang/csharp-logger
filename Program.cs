using System;
using System.IO;

namespace time_logger
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // string path; 
            string fileName = "log.txt";
            try 
            {
                DateTime locaDate = DateTime.Now;
                
                // Get curent path\
                string path = Directory.GetCurrentDirectory(); 
                string pathName = path + "\\" + fileName;

                Console.WriteLine(locaDate.ToString());
                Console.WriteLine(pathName);
                
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(pathName, true))
                {
                    file.WriteLine(locaDate.ToString());
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("THere's been an issue", e.ToString());
            }
        }
    }
}
