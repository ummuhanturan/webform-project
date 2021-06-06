using P.Domain.Abstract;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P.DataAccess.Concrete
{
    public class StudentRepository: GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(DatabaseContext databaseContext) : base(databaseContext) { }
        
        public void Update(Student student)
        {
            _databaseContext.Entry(student);
        }
    }
}
