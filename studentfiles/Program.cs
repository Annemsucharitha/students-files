using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataFromTextFile
{
    public class Program
    {
        static void filess()
        {
            string path = "C:\\Users\\Annem sucharitha\\MC\\studentfiles\\studentfiles.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string[] line = sr.ReadToEnd().Split('\n');
                    foreach (string x in line)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            else
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    sr.WriteLine("Student_Roll  : 4444");
                    sr.WriteLine("Student_Name  : seha");
                    sr.WriteLine("stuent_address: kerala");
                    sr.Close();
                }

                using (StreamReader sr2 = new StreamReader(path))
                {
                    String[] s2 = sr2.ReadToEnd().Split('\n');
                    foreach (String x in s2)
                    {
                        Console.WriteLine();
                    }
                    sr2.Close();
                }
            }
        }
        static void Main(string[] args)
        {
            filess();
        }
    }
}