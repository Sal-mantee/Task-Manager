using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class TaskService
    {
        public List<Task> tasks { get; set; }
        public TaskService() { tasks = new List<Task>(); }

        public void AddTask(string taskName, string Description)
        {
            tasks.Add(new Task(taskName, Description));
        }

        public void Update(string oldTaskName, string newTaskName, string Description)
        {
            var task = GetTask(oldTaskName);
            task.TaskName = newTaskName;
            task.Description = Description;

        }

        public void Delete(string taskName)
        {
            var task = GetTask(taskName);
            tasks.Remove(task);
        }

        public void MarkAsDone(string taskName)
        {
            var task = GetTask(taskName);
            task.Status = true;
        }

        public Task GetTask(string taskName) => tasks.FirstOrDefault(task => task.TaskName.Equals(taskName, StringComparison.OrdinalIgnoreCase));
    }
}
