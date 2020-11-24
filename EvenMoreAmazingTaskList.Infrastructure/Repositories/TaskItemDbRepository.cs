using EvenMoreAmazingTaskList.Domain.Entities;
using EvenMoreAmazingTaskList.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvenMoreAmazingTaskList.Infrastructure.Repositories
{
    public class TaskItemDbRepository : ITaskItemRepository
    {
        private readonly EvenMoreAmazingTaskListDbContext _db;

        public TaskItemDbRepository(EvenMoreAmazingTaskListDbContext db)
        {
            _db = db;
        }

        public void Create(TaskItem taskItem)
        {
            _db.Add(taskItem);
            _db.SaveChanges();
        }

        public IEnumerable<TaskItem> ReadAll()
        {
            return _db.TaskItems;
        }
    }
}
