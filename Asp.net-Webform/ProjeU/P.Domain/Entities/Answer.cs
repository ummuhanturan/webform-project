using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string RightAnswer { get; set; }
        public ICollection<string> WrongAnswers { get; set; }
    }
}
