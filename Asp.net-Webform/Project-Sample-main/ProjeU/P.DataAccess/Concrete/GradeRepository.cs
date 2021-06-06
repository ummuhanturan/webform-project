using P.Domain.Abstract;
using P.Domain.Entities;

namespace P.DataAccess.Concrete
{
    public class GradeRepository : GenericRepository<Grade>, IGradeRepository
    {
        public GradeRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public void Update(Grade grade)
        {
            _databaseContext.Entry(grade);
        }
    }
}
