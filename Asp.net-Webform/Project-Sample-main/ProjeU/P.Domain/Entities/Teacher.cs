using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Teacher: ApplicationUser
    {
        public ICollection<Course> Courses { get; set; }
    }
}
