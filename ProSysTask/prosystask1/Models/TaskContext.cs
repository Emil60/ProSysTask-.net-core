using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prosystask1.Models
{
    public class TaskContext: DbContext
    {
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }
    }
}
