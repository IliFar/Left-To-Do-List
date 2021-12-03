using System;
using System.Collections.Generic;
namespace app
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Task> taskList = new List<Task>();
            List<Task> archivedTasks = new List<Task>();

            while (true)
            {

                Console.WriteLine("LEFT TO DO\n");
                Console.WriteLine("*** WELCOME TO YOUR TODOLIST APP ***\n");
                Console.WriteLine("Choose From The Menu Below. To Choose A Menu Type A Number And Press Enter.\n");

                Console.WriteLine("What Would You Like To Do: ");

                string[] menu = { "[1] Add A Task", "[2] Check Your Tasks", "[3] See The Archived Tasks", "[4] Archive All The Completed Tasks", "[5] Exit" };

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine(menu[i]);
                }

                int choosenMenu = Convert.ToInt32(Console.ReadLine());

                switch (choosenMenu)
                {
                    case 1:
                        taskTypeMenu(taskList);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();

                        if (taskList != null)
                        {
                            Console.WriteLine("Choose a task number to mark it as done: ");
                            foreach (Task task in taskList)
                            {
                                var symbol = "";
                                if (task.marked)
                                {
                                    symbol = "X";
                                }
                                var number = taskList.IndexOf(task);
                                Console.WriteLine($"({number}) [ {symbol} ] {task.showTasks()}.");
                            }
                            foreach (Task task in taskList)
                            {
                                if (task.marked == false)
                                {
                                    var markInput = Convert.ToInt32(Console.ReadLine());
                                    var _task = taskList[markInput];
                                    task.marked = true;
                                }
                            }
                        }
                        Console.WriteLine("Choosen Tasks are marked successfully");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        foreach (var task in archivedTasks)
                        {
                            var number = taskList.IndexOf(task);
                            Console.WriteLine($"({number}) {task.showTasks()}");
                        }
                        Console.WriteLine("Press Enter To Go Back");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Are you sure ? (y/n)");
                        var sure = Convert.ToChar(Console.ReadLine());
                        if (sure == 'y')
                        {
                            foreach (Task task in taskList)
                            {
                                if (task.archived)
                                {
                                    taskList.Remove(task);
                                }
                                if (task.marked)
                                {
                                    archivedTasks.Add(task);
                                    task.archived = true;
                                }
                            }
                            Console.WriteLine("All marked tasks are archived.\nPress Enter To go back");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    default:
                        return;
                }
            }
        }

        public static void taskTypeMenu(List<Task> taskList)
        {
            Console.Clear();

            string[] taskTypeMenu = { "[1] Timeless Task", "[2] Deadline Task", "[3] CheckList Task", "[4] Exit" };
            for (int i = 0; i < taskTypeMenu.Length; i++)
            {
                Console.WriteLine(taskTypeMenu[i]);
            }
            var taskType = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (taskType)
            {
                case 1:
                    var timelessTaskMenu = new Menu();
                    var timeLessTask = new Timeless(timelessTaskMenu.timelessTaskInput());
                    timeLessTask.addTask(taskList);
                    Console.WriteLine("Task Added.");
                    break;
                case 2:
                    Console.WriteLine("Write Task Here: ");
                    var task = Console.ReadLine();
                    Console.WriteLine("Write a deadline for your task in dd/mm/yyyy format");
                    DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
                    DateTime today = DateTime.Today;
                    var daysLeft = inputtedDate - today;
                    var deadlineTask = new DeadLine(task, daysLeft);
                    deadlineTask.addTask(taskList);
                    Console.WriteLine("Task Added.");
                    break;
                case 3:

                    break;
                default:
                    return;
            }
            Console.ReadLine();
        }
    }
}
