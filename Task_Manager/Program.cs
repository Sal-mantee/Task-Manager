namespace Task_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Menue();
        }

        /* FEATURES
         * Add, edit, delete tasks.
         * Mark tasks as done.
         * Save/load tasks to a local file (JSON or XML).
         * Clean UI.*/

        private void Menue()
        {
            int choice_;
            do
            {
                Console.Clear();
                Console.WriteLine("\t==== Task Manager ===\n\n");
                Console.WriteLine("\t1. Add\n\t2. Edit\n\t3. Delete\n\t4. Mark task as done\n\t5. Exit");
                Console.Write("\n\tEnter your choice: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 0 && choice <= 5))
                    Console.Write("\tERROR!\n\tEnter a valid choice: ");
                choice = choice_;

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\tCase 1");
                        break;
                }
            }
            while (choice_ != 5);
        }
    }
}
