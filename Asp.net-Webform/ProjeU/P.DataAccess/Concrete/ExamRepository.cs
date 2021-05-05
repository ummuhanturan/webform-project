using P.Domain.Abstract;
using P.Domain.Entities;

namespace P.DataAccess.Concrete
{
    public class ExamRepository : GenericRepository<Exam>, IExamRepository
    {
        public ExamRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public void Update(Exam exam)
        {
            _databaseContext.Entry(exam);
        }
    }
}
