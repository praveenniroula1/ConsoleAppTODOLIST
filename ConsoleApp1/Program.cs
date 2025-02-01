using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "TO DO LIST APP";
            Console.ForegroundColor = ConsoleColor.Yellow;

             Console.WriteLine("ToDoList\n");
            Console.WriteLine("\nKeep Typing your Task\n\nTo End the program and view your tasks, simply press close after all your tasks entered:\n");
           string data= PressToContinue();

            List<string> tasks;
            tasks = new List<string>();
            tasks.Add(data);

            string close = "close";

            while(data != close)
            {
               data= PressToContinue();
                tasks.Add(data);
            }
            foreach (var item in tasks.Take(tasks.Count -1))
            {
                if (item == close)
                {

                }
                Console.WriteLine("\n"+item + "\n");
            }

            Console.ReadLine();

        }

        public static string PressToContinue()
        {
            Console.WriteLine("\nEnter a task:");
            return Console.ReadLine();

        }
    }
}

