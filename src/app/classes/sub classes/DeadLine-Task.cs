using System;
using System.Collections.Generic;

namespace app
{
    public class DeadLine : Task
    {
        public DeadLine(string task, TimeSpan date)
        {
            this.task = task;
            this.date = date;
            this.marked = false;
            this.archived = false;
        }

        public override void addTask(List<Task> taskList)
        {
            var deadlineTask = new DeadLine(task, date);
            taskList.Add(deadlineTask);
        }
        public override string showTasks()
        {
            return ($"{task} : Days Left Until Deadline {date.Days}");
        }
        public override string markCompletedTasks()
        {
            return "";
        }

        public override void archiveTask()
        {
            throw new NotImplementedException();
        }
    }


}
