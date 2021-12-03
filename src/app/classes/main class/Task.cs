using System;
using System.Collections.Generic;

namespace app
{
    public abstract class Task
    {
        // FIELDS
        // public List<Task> tasks = new();
        public string task;
        public bool marked;
        public bool archived;
        public int number;
        public TimeSpan date;

        // METHODS
        public abstract void addTask(List<Task> taskList);
        public abstract string showTasks();
        public abstract string markCompletedTasks();
        public abstract void archiveTask();
    }
}