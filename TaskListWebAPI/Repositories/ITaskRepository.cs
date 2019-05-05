using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskListWebAPI.Model;

namespace TaskListWebAPI.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<TaskItem> GetAll();
        TaskItem Get(int id);
        void AddTask(TaskItem taskItem);
        void UpdateTask(TaskItem taskItem);

    }
}
