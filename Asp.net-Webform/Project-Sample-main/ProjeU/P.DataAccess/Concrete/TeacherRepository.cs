using P.Domain.Abstract;
using P.Domain.Entities;
using System.Linq;

namespace P.DataAccess.Concrete
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public Teacher GetIdByEmail(string email)
        {
            var teacher = _databaseContext.Teachers.Where(x => x.Email == email).SingleOrDefault();
            return teacher;
        }

        public void Update(Teacher teacher)
        {
            _databaseContext.Entry(teacher);
        }
    }
}
