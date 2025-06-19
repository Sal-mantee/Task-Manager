using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task_Manager
{
    internal class Program
    {
        private const string fileName = "C:\\Users\\tello\\source\\repos\\Git Projects\\Task_Manager\\Tasks.txt";

        static void Main(string[] args)
        {
            Menue();
            Console.WriteLine("\tPress any key to exit...");
            Console.ReadKey();
        }

        /* FEATURES
         * Add, edit, delete tasks.
         * Mark tasks as done.
         * Save/load tasks to a local file (JSON or XML).
         * Clean UI.*/

        private static void Menue()
        {
            int choice_;
            var tasks = new List<Task>();
            do
            {
                Console.Clear();
                Console.WriteLine("\t==== Task Manager ===\n");
                Console.WriteLine("\t1. Add\n\t2. Edit\n\t3. Delete\n\t4. Mark task as done\n\t5. Exit");
                Console.Write("\n\tEnter your choice: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 0 && choice <= 5))
                    Console.Write("\tERROR!\n\tEnter a valid choice: ");
                choice_ = choice;

                switch (choice)
                {
                    case 1:
                        AddTask(tasks);
                        break;
                    case 2:
                        EditTask(tasks);
                        break;
                    case 3:
                        DeleteTask(tasks);
                        break;
                }
                if (choice != 5)
                {
                    Console.WriteLine("\tPress any key to continue...");
                    Console.ReadKey();
                }
            }
            while (choice_ != 5);
        }
        #region Add
        private static void AddTask(List<Task> tasks)
        {
            Console.Clear();
            Console.WriteLine("\t=== Adding Task ===\n");

            Console.Write("\tEnter a task name: ");
            string taskName = Console.ReadLine();
            Console.Write("\tEnter a description of a task: ");
            string taskDiscription = Console.ReadLine();
            Task task = new Task(taskName, taskDiscription);
            tasks.Add(task);

            Console.WriteLine($"\tTask '{taskName}' added successfully.");
        }
        #endregion
        #region Edit
        private static void EditTask(List<Task> tasks)
        {
            Console.Clear();
            Console.WriteLine("\t=== Editing Task ===\n");

            Console.Write("\tEnter a task to edit: ");
            string taskName = Console.ReadLine();

            if (tasks.Count == 0)
                Console.WriteLine("\tAdd tasks first.");
            else
            {
                var task = tasks.FirstOrDefault(task => task.TaskName == taskName);

                if (task != null)
                {
                    Console.Write($"\tUpdate name of the task named '{taskName}': ");
                    task.TaskName = Console.ReadLine();
                    Console.Write($"\n\tUpdate desciption of the task named '{taskName}': ");
                    task.Description = Console.ReadLine();
                    Console.WriteLine("\tUpdated successfully.");
                }
                else
                    Console.WriteLine($"\tTask '{taskName} not found.'");
            }
        }
        #endregion
        #region Delete
        private static void DeleteTask(List<Task> tasks)
        {
            Console.Clear();
            Console.WriteLine("\t=== Deleting Task ===\n");

            Console.Write("\tEnter a task to delete: ");
            string taskName = Console.ReadLine();

            if (tasks.Count == 0)
                Console.WriteLine("\tAdd tasks first.");

            var task = tasks.FirstOrDefault(task => task.TaskName == taskName);
            if (task!= null)
            {
                tasks.Remove(task);
                Console.WriteLine($"\tTask '{taskName}' deleted successfully.");
            }
            else
                Console.WriteLine($"\tTask '{taskName}' is not found.");
        }
        #endregion
        //private static List<Task> GetTasks()
        //{
        //    List<Task> tasks = new List<Task>();

        //    if (!File.Exists(fileName))
        //    {
        //        using (StreamWriter writer = new StreamWriter(fileName, false))
        //        {
        //            writer.WriteLine("Read hardware");
        //        }
        //    }

        //    using (StreamReader reader = new StreamReader(fileName))
        //    {
        //        //tasks.Add(new Task(reader.ReadLine()[0], );
        //    }
        //    return tasks;
        //}
    }
}
