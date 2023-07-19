using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace ToDoApi.Data {
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}