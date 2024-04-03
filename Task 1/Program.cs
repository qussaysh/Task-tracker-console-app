


using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace TaskTaraker
{
    internal class prorgram
    {

                    // Task tracker 

        // Welcome user

        // 1- Add task
        // 2- view all tasks
        // 3- mark task complete
        // 4- remove task
        // 5- Exit

        static string[] tasks = new string[100];
        static int taskIndex = 0;

        public static void ChoicesList()
        {
            Console.WriteLine("Enter Your choice form 1 to 5");
            Console.WriteLine("1.Add task");
            Console.WriteLine("2.View all tasks");
            Console.WriteLine("3.Mark task complete");
            Console.WriteLine("4.Remove task");
            Console.WriteLine("5.Exit");
        }

        private static void addTask()
        {
            Console.WriteLine("Enter Task title : ");
            string taskTitle = Console.ReadLine();
            tasks[taskIndex] = taskTitle;
            taskIndex++;
            
        }

        private static void viewAllTasks()
        {

            Console.WriteLine("Tasks list : \n");
            for(int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i+1}. Task title \" {tasks[i]} \" ");

            }
        }

        private static void markTaskComplete()
        {
            Console.WriteLine("Enter Task number");
            int taskNumber = int.Parse(Console.ReadLine());
            tasks[taskNumber - 1] = tasks[taskNumber - 1] + "   ---------COMPLETED---------";
        }
        private static void deleteTask()
        {
            Console.WriteLine("Enter Task number to delete");
            int taskNumber = int.Parse(Console.ReadLine());
            tasks[taskNumber - 1] = string.Empty;
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to my task tracker");
            do
            {
                Console.WriteLine("\n");
                ChoicesList();
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        addTask();
                        // Add task
                        break;
                    case "2":
                        viewAllTasks();
                        // View all tasks
                        break;
                    case "3":
                        markTaskComplete();
                        // Mark task complete
                        break;
                    case "4":
                        deleteTask();
                        // Remove task
                        break;
                    case "5":
                        Environment.Exit(0);
                        // Exit
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (true);

           
            
            
        }
    }
}
