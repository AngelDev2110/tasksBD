using Microsoft.EntityFrameworkCore;

namespace tasksBD.Models
{
    public class TasksManagement : DbContext
    {
        public TasksManagement(DbContextOptions<TasksManagement> options): base(options) { 
        
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberTask> Tasks { get; set; }
    }
}
