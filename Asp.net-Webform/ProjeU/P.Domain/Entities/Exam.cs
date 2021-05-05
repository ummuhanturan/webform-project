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
        [Required, StringLength(30)]
        public string Name { get; set; }
        public Question Question { get; set; }
        public Grade Grade { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
