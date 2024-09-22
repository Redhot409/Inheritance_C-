//#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE
            StreamWriter sw = new StreamWriter("File.txt");
            sw.WriteLine("Hello files");
            sw.Close();
            Process.Start("notepad", "File.txt"); 
#endif      
            StreamReader sr = new StreamReader("File.txt");
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }

            sr.Close();
        }
    }
}
