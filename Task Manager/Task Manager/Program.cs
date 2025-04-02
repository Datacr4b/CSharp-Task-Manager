using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class Program
    {
        private static List<string> tasks = new List<string>(); // define lists 
        static void Main(string[] args)
        {
            string userInput;

            while (true) // Main program loop
            {
                Console.WriteLine("Welcome to the Task Manager");
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. Remove a Task");
                Console.WriteLine("3. View Tasks");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter a task to add: ");
                        userInput = Console.ReadLine();
                        AddTask(userInput); // Simple Add Task
                        break;
                    case "2":
                        Console.Clear();
                        RemoveTask();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Here are all the tasks");
                        foreach (string task in tasks)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }


            }

        }

        static void AddTask(string userInput)
        {
            tasks.Add(userInput);
        }

        static void RemoveTask()
        {
            string userInput;
            int index = 0;
            Console.WriteLine("1.Remove Task by Name");
            Console.WriteLine("2.Remove Task by Index");
            Console.WriteLine("3.Remove Last Task");
            userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Enter the name: ");
                    try
                    {
                        userInput = Console.ReadLine();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    tasks.Remove(userInput);

                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Enter the index: ");
                    try
                    {
                        index = Convert.ToInt32(value: Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    if (index < tasks.Count - 1)
                        tasks.RemoveAt(index);
                    else
                        Console.WriteLine("Invalid index");
                        break;
                case "3":
                    Console.Clear();
                    index = tasks.Count;
                    tasks.RemoveAt(index-1);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
