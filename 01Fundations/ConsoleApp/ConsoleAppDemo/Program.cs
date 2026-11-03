using System;
using System.Collections.Generic;  // Needed for List<T>

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<string> tasks = new List<string>();
        while (true)
        {
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string? choiceInput = Console.ReadLine();
            if (choiceInput is null)
            {
                Console.WriteLine("\nInput closed. Exiting.");
                return;
            }

            if (int.TryParse(choiceInput.Trim(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        break;

                    case 2:
                        Console.Write("Enter the task: ");
                        string? task = Console.ReadLine()?.Trim();
                        if (string.IsNullOrWhiteSpace(task))
                        {
                            Console.WriteLine("Task description cannot be empty.");
                            break;
                        }

                        tasks.Add(task);
                        Console.WriteLine("Task added.");
                        break;

                    case 3:
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available to complete.");
                            break;
                        }

                        Console.WriteLine("Enter the task number to mark complete: ");
                        string? taskNumberInput = Console.ReadLine();
                        if (taskNumberInput is null)
                        {
                            Console.WriteLine("\nInput closed. Exiting.");
                            return;
                        }

                        if (int.TryParse(taskNumberInput.Trim(), out int taskNumber) &&
                            taskNumber >= 1 &&
                            taskNumber <= tasks.Count)
                        {
                            int taskIndex = taskNumber - 1;
                            if (tasks[taskIndex].EndsWith(" [Complete]", StringComparison.Ordinal))
                            {
                                Console.WriteLine("That task is already complete.");
                            }
                            else
                            {
                                tasks[taskIndex] += " [Complete]";
                                Console.WriteLine("Task marked as complete.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid task number. Enter a number from 1 to {tasks.Count}.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Goodbye.");
                        return;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }






        // // Step 1: Integrating If-Else with Loops
        // do
        // {
        //     int input;
        //     Console.WriteLine("Please input an even number between 1 and 10");
        //     input = int.Parse(Console.ReadLine());
        //     if (input >= 1 && input <= 10)
        //     {
        //         Console.WriteLine("the input number is " + input);
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("the input is valid.");
        //     }

        // } while (true);

        // // Step 2: Using If-Else to Evaluate Grades
        // int[] grades = { 95, 86, 76, 65, 55 };
        // for (int i = 0; i < grades.Length; i++)
        // {
        //     if (grades[i] > 65)
        //     {
        //         Console.WriteLine("The grade is " + grades[i] + " - Pass");
        //     }
        //     else
        //     {
        //         Console.WriteLine("The Grade is " + grades[i] + " - Fail");
        //     }
        // }

        // // Step 3: Integrating Switch Statements with Loops
        // string[] orderStatuses = { "Pending", "Shipped", "Delivered", "Cancelled", };
        // for (int i = 0; i < orderStatuses.Length; i++)
        // {
        //     switch (orderStatuses[i])
        //     {
        //         case "Pending":
        //             Console.WriteLine("Order is Pending.");
        //             break;
        //         case "Shipped":
        //             Console.WriteLine("Order has been shipped.");
        //             break;
        //         case "Delivered":
        //             Console.WriteLine("Order has been Delivered.");
        //             break;
        //         case "Cancelled":
        //             Console.WriteLine("Order has been cancelled.");
        //             break;
        //         default:
        //             Console.WriteLine("Status of Order is invalid.");
        //             break;
        //     }
        // }

        // // Step 4: Evaluating Student Grades with Switch and Loops
        // int[] studentScores = { 99, 87, 68, 87, 76, 52, 64 };
        // for (int i = 0; i < studentScores.Length; i++)
        // {
        //     int score = studentScores[i];
        //     switch (score)
        //     {
        //         case int n when (n >= 90):
        //             Console.WriteLine("Grade A: Excellent!");
        //             break;
        //         case int n when (n >= 80):
        //             Console.WriteLine("Grade B: Good job!");
        //             break;
        //         case int n when (n >= 70):
        //             System.Console.WriteLine("Grade C: Fair.");
        //             break;
        //         case int n when (n >= 60):
        //             System.Console.WriteLine("Grade D: Needs improvement.");
        //             break;
        //         default:
        //             System.Console.WriteLine("Grade F: Fail.");
        //             break;
        //     }
        // }

        // // Activity: Introduction to Functions in Programming
        // // Problem 1: Creating a Function for Circle Area Calculation
        // static double CalculateCircleArea(double radius)
        // {
        //     return Math.PI * radius * radius;
        // }

        // System.Console.WriteLine("Enter the radius of the circle: ");
        // double radius = Convert.ToDouble(Console.ReadLine());
        // double area = CalculateCircleArea(radius);
        // System.Console.WriteLine("The area of the circle is: " + area);

        // // Problem 2: Creating a Function for Trapezoid Area Calculation
        // static double CalculateTrapezoidArea(double a, double b, double height)
        // {
        //     return ((a + b) / 2) * height;
        // }
        // System.Console.WriteLine("Enter the length of upside side of the Trapezoid: ");
        // double upside = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Enter the length of downside side of the Trapezoid: ");
        // double downside = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Enter the height of the Trapezoid: ");
        // double height = Convert.ToDouble(Console.ReadLine());
        // double trapezoidArea = CalculateTrapezoidArea(upside, downside, height);
        // System.Console.WriteLine($"The area of the circle is {trapezoidArea}");

        // Step 1: Defining and Calling a Simple Method
        // DisplayWelcomeMessage();

        // // Step 2: Creating a Method with Parameters
        // GreetUser("Ray");
        // // Step 3: Using Methods with Return Values
        // CalculateSum(1, 2);
        // // Step 4: Combining Methods and Conditional Logic
        // int num = 1;
        // if (isPositive(num))
        // {
        //     System.Console.WriteLine($"The number {num} is Positive");
        // }
        // // Step 5: Practical Application – User Age Validation
        // System.Console.WriteLine("Please input your age: ");
        // int age = int.Parse(Console.ReadLine());
        // if (IsOldEnoughToDrive(age))
        // {
        //     System.Console.WriteLine($"You are {age} years old, and you can drive.");
        // }
        // else
        // {
        //     System.Console.WriteLine("You are not old enough to drive.");
        // }
        // Problem 1: Calculate the Volume of a Rectangular Box

        // static int CalculateRectangularVolume(int length, int width, int height)
        // {
        //     return length * width * height;
        // }

        // static int CalculateAverageOfNumber(int num1, int num2, int num3)
        // {
        //     return (num1 + num2 + num3) / 3;
        // }

        //     string task1 = string.Empty;
        //     string task2 = string.Empty;
        //     string task3 = string.Empty;

        //     bool task1Finished = false;
        //     bool task2Finished = false;
        //     bool task3Finished = false;

        //     System.Console.WriteLine("Please input a task: ");
        //     string userTask = Console.ReadLine();
        //     if (task1 == string.Empty)
        //     {
        //         task1 = userTask;
        //     }
        //     else if (task2 == string.Empty)
        //     {
        //         task2 = userTask;
        //     }
        //     else if (task3 == string.Empty)
        //     {
        //         task3 = userTask;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("No more task can be added.");
        //     }

        //     System.Console.WriteLine("Which task you want to mark finished (1, 2, 3) ? ");
        //     int finishMark = int.Parse(Console.ReadLine());
        //     if (finishMark == 1)
        //     {
        //         task1Finished = true;
        //     }
        //     else if (finishMark == 2)
        //     {
        //         task2Finished = true;
        //     }
        //     else if (finishMark == 3)
        //     {
        //         task3Finished = true;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("You selected an invalid task number.");
        //     }

        //     if (task1Finished)
        //     {
        //         System.Console.WriteLine("task1 Completed");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("task1 Pending");
        //     }

        //     if (task2Finished)
        //     {
        //         System.Console.WriteLine("task2 Completed");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("task2 Pending");
        //     }

        //     if (task2Finished)
        //     {
        //         System.Console.WriteLine("task3 Completed");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("task3 Pending");
        //     }

        // }

        // public char CalculateGrade(int studentScore)
        // {
        //     return studentScore switch
        //     {
        //         >= 90 => 'A',
        //         >= 80 => 'B',
        //         >= 70 => 'C',
        //         >= 60 => 'D',
        //         _ => 'F'
        //     };
        // }

        // public static void DisplayWelcomeMessage()
        // {
        //     System.Console.WriteLine("Welcome to our Program!");
        // }

        // public static void GreetUser(string name)
        // {
        //     System.Console.WriteLine($"Hello {name}!");
        // }

        // public static int CalculateSum(int a, int b)
        // {
        //     return a + b;
        // }

        // public static bool isPositive(int number)
        // {
        //     return number > 0;
        // }

        // public static bool IsOldEnoughToDrive(int age)
        // {
        //     return age > 18;
        // }
    }
}
