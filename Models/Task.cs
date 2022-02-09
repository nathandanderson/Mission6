using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Task
    {
        [Key]
        [Required]
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        [Required]
        public int Quadrant { get; set; }
        public bool Completed { get; set; }

        // Build a foreign key relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}