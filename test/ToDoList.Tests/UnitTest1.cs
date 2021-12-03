using System;
using Xunit;
using System.Collections.Generic;
using app;


namespace todolist.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Should_AddTimelessTask()
        {
            // Arrange
            List<Task> tasks = new List<Task>(); // TASK LIST

            var timelessTask = new Timeless("Timeless task"); //Instance of a timeless task

            // ACT
            tasks.Add(timelessTask);

            // Assert
            Assert.NotEmpty(tasks);
        }
        [Fact]
        public void Test_Should_AddDeadlineTask()
        {

            List<Task> tasks = new List<Task>(); // TASK LIST

            var d1 = DateTime.Today; //Today's Date
            var d2 = DateTime.Parse("05/05/2022"); //Random Deadline date
            var DeadlineTask = new DeadLine("Deadline task", d1 - d2); //Instance of a deadline task

            tasks.Add(DeadlineTask);

            Assert.Contains(DeadlineTask, tasks);
        }
        // [Fact]
        // public void Test_Should_MarkTask()
        // {

        //     List<Task> tasks = new List<Task>();
        //     var timelessTask = new Timeless("Timeless task");

        //     bool result = timelessTask.marked;
            
        //     var symbol = "X";

        //     Assert.True(result, timelessTask.showTasks());
        // }

    }
}
