using System.ComponentModel.DataAnnotations;

namespace TaskListWebAPI.Model
{
    public class TaskItem
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string name { get; set; }
        public string nescription { get; set; }
        public bool done { get; set; }
    }
}
