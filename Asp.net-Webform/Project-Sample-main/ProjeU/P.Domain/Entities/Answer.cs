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
        public string answerContent { get; set; }
        public bool isTrue { get; set; }
    }
}
