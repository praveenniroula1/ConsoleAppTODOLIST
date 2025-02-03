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
            string data = PressToContinue();

            List<string> tasks;
            tasks = new List<string>();
            tasks.Add(data);

            string close = "close";

            while (data != close)
            {
                data = PressToContinue();
                tasks.Add(data);
            }
            //foreach (var item in tasks.Take(tasks.Count -1))
            //{
            //    if (item == close)
            //    {

            //    }
            //    Console.WriteLine("\n\nThis are your tasks:"+item + "\n");
            //} 

            for (int i = 0; i < tasks.Count - 1; i++)
            {
                Console.WriteLine($"\n\n{i + 1}" + " " + tasks[i] + "\n");
            }

            Console.WriteLine("Are You willing to delet any of your task? ");
            Console.WriteLine("yes or no ");
            string decision = Console.ReadLine();
            if (decision == "yes")
            {
                Console.WriteLine("You pressed Yes, which number of task You like to delete? ");
                string whichTask = Console.ReadLine();
                for (int i = 0; i < tasks.Count - 1; i++)
                {
                   int del= Convert.ToInt32(whichTask);
                    tasks.RemoveAt(del); 
                    Console.WriteLine($"\n\n{i + 1}" + " " + tasks[i] + "\n");

                }

            }
            string decisionToDel = Console.ReadLine();

            bool delete = false;

            if (delete)
            {
                for (int i = 0; i < tasks.Count - 1; i++)
                {
                    Console.WriteLine($"\n\n{i + 1}" + " " + tasks[i] + "\n");
                }
            }
            else
            {
                for (int i = 0; i < tasks.Count - 1; i++)
                {
                    tasks.RemoveAt(i);
                    Console.WriteLine($"\n\n{i + 1}" + " " + tasks[i] + "\n");

                }
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

