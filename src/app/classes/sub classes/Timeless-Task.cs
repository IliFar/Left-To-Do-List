using System;
using System.Collections.Generic;

namespace app
{
    public class Timeless : Task
    {
        public Timeless(string task)
        {
            this.task = task;
            this.marked = false;
            this.archived = false;
        }
        
        public override void addTask(List<Task> taskList)
        {
            var timeLessTask = new Timeless(task);
            taskList.Add(timeLessTask);
        }
        public override string showTasks()
        {
            return task;
        }
        public override string markCompletedTasks()
        {
            return task;
        }
        public override void archiveTask()
        {
            throw new NotImplementedException();
        }
    }
}