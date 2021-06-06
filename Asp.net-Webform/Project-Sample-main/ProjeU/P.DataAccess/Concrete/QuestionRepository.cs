using P.Domain.Abstract;
using P.Domain.Entities;

namespace P.DataAccess.Concrete
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public void Update(Question question)
        {
            _databaseContext.Entry(question);
        }
    }
}
