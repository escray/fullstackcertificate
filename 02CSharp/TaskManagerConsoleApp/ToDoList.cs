class ToDoList
{
    public static string[] tasks = new string[10];
    static int taskCount = 0;

    public static void AddTask()
    {
        System.Console.WriteLine("Please enter a task: ");
        tasks[taskCount] = Console.ReadLine();
        taskCount++;
    }

    public static void ViewTasks()
    {
        if (taskCount <= 0)
        {
            System.Console.WriteLine("The todo list is empty.");
            return;
        }
        for (int i = 0; i < taskCount; i++)
        {
            System.Console.WriteLine((i + 1) + "-" + tasks[i]);
        }
        return;
    }

    public static void CompleteTask()
    {
        System.Console.WriteLine("Select a task to mark as complete");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;
        System.Console.WriteLine("taskNumber: " + (taskNumber) + " of " + taskCount);
        if (taskNumber >= 0 && taskNumber < taskCount)
        {
            tasks[taskNumber] = "completed";
        }
        else
        {
            System.Console.WriteLine("invalid task number.");
        }
        return;
    }

    public static void Main(string[] args)
    {


        bool running = true;
        string choice = "";
        while (running)
        {
            System.Console.WriteLine("Please input your choice (1~4):");
            System.Console.WriteLine("1 view tasks");
            System.Console.WriteLine("2 add task");
            System.Console.WriteLine("3 mark task completed");
            System.Console.WriteLine("4 exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    System.Console.WriteLine("invalid choide input");
                    break;
            }
        }
        System.Console.WriteLine("EXIT");
    }
}

