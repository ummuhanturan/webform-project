using P.Domain.Entities;

namespace P.Domain.Abstract
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        void Update(Question question);
    }
}
