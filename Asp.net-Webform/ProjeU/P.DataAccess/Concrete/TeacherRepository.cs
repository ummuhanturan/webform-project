using P.Domain.Abstract;
using P.Domain.Entities;

namespace P.DataAccess.Concrete
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public void Update(Teacher teacher)
        {
            _databaseContext.Entry(teacher);
        }
    }
}
