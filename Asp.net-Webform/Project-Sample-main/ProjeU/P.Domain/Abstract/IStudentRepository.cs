using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Abstract
{
    public interface IStudentRepository: IGenericRepository<Student>
    {
        void Update(Student student);
    }
}
