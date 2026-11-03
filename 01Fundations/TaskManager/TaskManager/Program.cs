class TaskManager
{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>();

    static void Main(string[] args)
    {
        while (true)
        {
            System.Console.WriteLine("Task Manager");
            System.Console.WriteLine("1. Add Task");
            System.Console.WriteLine("2. Mark Task as Completed");
            System.Console.WriteLine("3. View Tasks");
            System.Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    private static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            System.Console.WriteLine("No tasks available.");
            return;
        }
        System.Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = taskStatus[i] ? "Completed" : "Pending";
            System.Console.WriteLine($"{i + 1}.{tasks[i]} - {status}");
        }
    }

    private static void CompleteTask()
    {
        if (tasks.Count == 0)
        {
            System.Console.WriteLine("No tasks available to complete.");
            return;
        }
        System.Console.WriteLine("Enter task number to mark as completed:");
        if (
            int.TryParse(Console.ReadLine(), out int taskNumber)
            && taskNumber > 0
            && taskNumber <= tasks.Count
        )
        {
            taskStatus[taskNumber - 1] = true;
            System.Console.WriteLine($"Task '{tasks[taskNumber - 1]}' marked as completed.");
        }
        else
        {
            System.Console.WriteLine("Invalid task number.");
        }
    }

    private static void AddTask()
    {
        System.Console.WriteLine("Enter task description:");
        string task = Console.ReadLine();
        tasks.Add(task);
        taskStatus.Add(false);
        System.Console.WriteLine("Task Added Successfully");
    }
}
