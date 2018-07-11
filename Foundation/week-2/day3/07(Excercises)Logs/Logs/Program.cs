using System;
using System.Collections.Generic;
using System.IO;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
            {
                string path = @"log.txt";
                Console.WriteLine(Log(path));

                foreach (var item in IpAddress(path))
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
            public static string Log(string logGet)
            {
                int getAmount = 0;
                int postAmount = 0;
                foreach (string line in File.ReadAllLines(logGet))
                {
                    if (line.Contains("GET"))
                    {
                        getAmount++;
                    }
                    else if (line.Contains("POST"))
                    {
                        postAmount++;
                    }
                }

                return "The GET and POST ratio is : " + getAmount + "/" + postAmount;
            }

            public static List<string> IpAddress(string IpGet)
            {
                string[] content = File.ReadAllLines(IpGet);
                List<string> listOfUniq = new List<string>();

                for (int i = 0; i < content.Length; i++)
                {
                    content[i] = content[i].Substring(27, 11);

                    if (!listOfUniq.Contains(content[i]))
                    {
                        listOfUniq.Add(content[i]);
                    }
                }
                return listOfUniq;
            }
        }
    }