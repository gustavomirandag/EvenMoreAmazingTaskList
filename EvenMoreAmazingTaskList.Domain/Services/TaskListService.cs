using EvenMoreAmazingTaskList.Domain.Entities;
using EvenMoreAmazingTaskList.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvenMoreAmazingTaskList.Domain.Services
{
    public class TaskListService
    {
        private readonly ITaskItemRepository _repository;

        public TaskListService(ITaskItemRepository repository)
        {
            _repository = repository;
        }

        //Use Cases of the Functional Requirement: Manage TaskList


        /// <summary>
        /// Add a new TaskItem to the TaskList
        /// </summary>
        /// <param name="taskItem"></param>
        /// <returns>Return TRUE if the TaskItem was added or FALSE if not.</returns>
        public bool AddTaskItem(TaskItem taskItem)
        {
            //Verifica se essa tarefa já deveria ter sido feita.
            if (taskItem.DateTime < DateTime.Now)
                return false; //Não cadastro NADA.

            //Persistência usando o Repositório!!!!!!
            _repository.Create(taskItem);

            return true;
        }

        public IEnumerable<TaskItem> GetAllTaskItems()
        {
            //Retornar os TaskItems da Persistência usando o Repositório!!!!!!
            return _repository.ReadAll();
        }
    }
}
