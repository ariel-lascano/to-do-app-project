using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI
{
    /// <summary>
    /// Bridge between database table and runtime object for data management.
    /// </summary>
    public class ApplicationDatabaseContext : DbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base (options)
        {
        }

        /// <summary>
        /// Collection of entries picked from database by EntityFramework:
        /// </summary>
        public DbSet<ToDoItem> Data { get; set; }
    }
}
