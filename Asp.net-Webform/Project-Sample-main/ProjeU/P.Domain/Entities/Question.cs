using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        [StringLength(20)]
        public string Type { get; set; }
        public string Content { get; set; }
        public ICollection<Answer> Answers { get; set; }

    }
}
