using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args.Length > 2)
            {
                Console.WriteLine("Пример: HelloWord.exe Frodo 21");
                return;
            }

            string name = string.Empty;
            int number = 0;
            bool hasAge = false;
            foreach (string arg in args)
            {
                int value;
                if (int.TryParse(arg, out value))
                {
                    if (hasAge || value < 0)
                    {
                        Console.WriteLine("Укажи одно имя и неотрицательный возраст.");
                        return;
                    }
                    number = value;
                    hasAge = true;
                }
                else
                {
                    if (name != string.Empty || string.IsNullOrWhiteSpace(arg))
                    {
                        Console.WriteLine("Укажи одно имя и возраст числом.");
                        return;
                    }
                    name = arg.Trim();
                }
            }
            if (name == string.Empty)
            {
                Console.WriteLine("Укажи имя.");
                return;
            }

            if (hasAge && number >= 18)
                Console.WriteLine($"Здравствуйте, {name}!");
            else
                Console.WriteLine($"Привет, {name}!");
        }
    }
}
