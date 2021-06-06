using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(30)]
        public string CourseCode { get; set; }
        [Required]
        public int TeacherId { get; set; }
        public ICollection<ApplicationUser> Students { get; set; } 
        public ICollection<Exam> Exams { get; set; }
    }
}
