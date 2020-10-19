using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushArray
{
    class Program
    {
        static void Main(string[] args)
        {
            PushArray();
        }

        private static void PushArray()
        {
            Console.Clear();

            Console.Write(" enter array of char : ");
            char[] arr = Console.ReadLine().ToCharArray();
            Console.Clear();

            Console.Write(" enter number of print array : ");
            int rows = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"\n array will print {rows} times \n _________________________ \n");
            Console.ForegroundColor = ConsoleColor.Green;

            int index = arr.Length - 1;
            char lastValue = arr[index];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (index == 0)
                    {
                        arr[index] = lastValue;
                        index = arr.Length - 1;
                        lastValue = arr[index];
                    }
                    else
                    {
                        arr[index] = arr[index - 1];
                        index--;
                    }
                }
                foreach (var item in arr)
                {
                    System.Threading.Thread.Sleep(300);
                    Console.Write($" {item}");
                }
                Console.WriteLine("\n");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" _________________________ \n\n Try Again (y/n) : ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "y")
            {
                PushArray();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" _________________________ \n\n mina-noshy@outlook.com \n 002 0111 125 7052");
                Console.ReadLine();
            }
                
        }

    }
}
