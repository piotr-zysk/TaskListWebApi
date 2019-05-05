using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskListWebAPI.Db;
using TaskListWebAPI.Model;

namespace TaskListWebAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        protected TaskDbContext _dataContext;
        public TaskRepository(TaskDbContext dataContext)
        {
            this._dataContext = dataContext;
        }


        public void AddTask(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }

        public TaskItem Get(int id)
            => _dataContext.Set<TaskItem>().FirstOrDefault(t => t.id == id);

        public IEnumerable<TaskItem> GetAll()
            => _dataContext.Set<TaskItem>().ToList();

        public void UpdateTask(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }
    }
}
