using System;
using System.Collections.Generic;

namespace app
{
    public class Menu
    {
        public string timelessTaskInput()
        {
            Console.WriteLine("Write the task below: ");
            var taskInput = Console.ReadLine();
            return taskInput;
        }
        
    }
}