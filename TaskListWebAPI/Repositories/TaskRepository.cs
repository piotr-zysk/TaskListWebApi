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


        public void Add(TaskItem taskItem)
        {
            _dataContext.Set<TaskItem>().Add(taskItem);
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var taskItem = new TaskItem { id = id };
            _dataContext.Set<TaskItem>().Attach(taskItem);
            _dataContext.Set<TaskItem>().Remove(taskItem);
            _dataContext.SaveChanges();

        }

        public TaskItem Get(int id)
            => _dataContext.Set<TaskItem>().FirstOrDefault(t => t.id == id);

        public IEnumerable<TaskItem> GetAll()
            => _dataContext.Set<TaskItem>().ToList();

        public void Update(TaskItem taskItem)
        {
            _dataContext.Set<TaskItem>().Attach(taskItem);
            _dataContext.Entry(taskItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dataContext.SaveChanges();
        }
    }
}
