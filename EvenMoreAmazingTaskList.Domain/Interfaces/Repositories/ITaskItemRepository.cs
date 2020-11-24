using EvenMoreAmazingTaskList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvenMoreAmazingTaskList.Domain.Interfaces.Repositories
{
    //Repository only understands CRUD (Create, Read, Update, Delete)
    public interface ITaskItemRepository
    {
        public void Create(TaskItem taskItem);
        public IEnumerable<TaskItem> ReadAll();
    }
}
