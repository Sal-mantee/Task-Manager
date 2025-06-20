using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class Task
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public Task(string taskName, string description, bool status = false)
        {
            TaskName = taskName;
            Description = description;
            Status = status;
        }

        public override string ToString() => $"{TaskName}, {Description}, ({Status})";
    }
}
