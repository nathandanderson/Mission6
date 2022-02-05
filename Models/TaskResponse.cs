using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TaskResponse
    {
//        @*Task(Required)
//• Due Date
//• Quadrant(Required)
//• Category(Dropdown containing options: Home, School, Work, Church)
//• Completed(True/False)*@

        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public int Quadrant { get; set; }
        [Required]
        public bool Completed { get; set; }


        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
