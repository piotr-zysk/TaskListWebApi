using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskListWebAPI.Model;

namespace TaskListWebAPI.Db
{
    public class TaskDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=TaskList;Trusted_Connection=True;");
        }
    }
}
