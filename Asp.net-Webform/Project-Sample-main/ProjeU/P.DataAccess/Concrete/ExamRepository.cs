using P.Domain.Abstract;
using P.Domain.Entities;
using System.Linq;

namespace P.DataAccess.Concrete
{
    public class ExamRepository : GenericRepository<Exam>, IExamRepository
    {
        public ExamRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public Exam getExamByCode(string Code)
        {
            return _databaseContext.Exams.Where(x => x.examCode.ToString() == Code).SingleOrDefault();
        }

        public void Update(Exam exam)
        {
            _databaseContext.Entry(exam);
        }
    }
}
