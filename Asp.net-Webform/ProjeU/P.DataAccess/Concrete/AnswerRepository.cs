using P.Domain.Abstract;
using P.Domain.Entities;

namespace P.DataAccess.Concrete
{
    public class AnswerRepository : GenericRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public void Update(Answer answer)
        {
            _databaseContext.Entry(answer);
        }
    }
}
