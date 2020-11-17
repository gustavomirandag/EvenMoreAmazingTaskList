using System;
using System.Collections.Generic;
using System.Text;

namespace EvenMoreAmazingTaskList.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
