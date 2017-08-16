using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] lines = File.ReadAllLines(@"c:\DoublesLog\doublesTest.txt", Encoding.UTF8);
            Boolean hasDouble = false;

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = i + 1; j < lines.Length; j++)
                {
                    if ((lines[i] == lines[j]) && (lines[i] != ""))
                    {
                        hasDouble = true;
                        Console.WriteLine(i + "," + j);
                        Console.WriteLine(lines[i]);
                        Console.WriteLine(lines[j]);
                    }
                }
            }

            Console.WriteLine("Double status: " + hasDouble);
        }
    }
}
