using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public string examCode { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; } 
        public ICollection<Question> Questions { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<ApplicationUser> Students { get; set; }
    }
}
