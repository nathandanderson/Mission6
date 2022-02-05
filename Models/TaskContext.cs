using Microsoft.EntityFrameworkCore;
using static Mission6.Models.TasksResponse;

namespace Mission6.Models
{
    public class TaskContext : DbContext
    {
        // Constructor
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<TasksResponse> Entries { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home" },
                new Category { CategoryID = 2, CategoryName = "School" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Church" }
            );

            mb.Entity<TasksResponse>().HasData(

                new TasksResponse
                {
                    TaskID = 1,
                    TaskName = "Mission6 Assignment",
                    DueDate = '02/09/22',
                    Quadrant = 1,
                    CategoryID = 2,
                    Completed = false
                },

                new TasksResponse
                {
                    TaskID = 2,
                    TaskName = "Laundry",
                    DueDate = "02/12/22",
                    Quadrant = 3,
                    CategoryID = 1,
                    Completed = false
                },

                new TasksResponse
                {
                    TaskID = 3,
                    TaskName = "Respond to emails",
                    DueDate = "None",
                    Quadrant = 4,
                    CategoryID = 1,
                    Completed = false
                },

                new TasksResponse
                {
                    TaskID = 4,
                    TaskName = "Relationship Building",
                    DueDate = "None",
                    Quadrant = 2,
                    CategoryID = 4,
                    Completed = false
                }
            );
        }
    }
}