

using System;
using System.IO;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                int count = 0;
                int sum = 0;
                StreamReader sr = new StreamReader("D:\\projects C#\\task_2\\input.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    line = line.Trim();
                    if (!line.Contains("."))
                    {
                        sum += Int32.Parse(line);
                        count++;   
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("Сумма целых чисел: " + sum);
                Console.WriteLine("Количество целых чисел: " + count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
