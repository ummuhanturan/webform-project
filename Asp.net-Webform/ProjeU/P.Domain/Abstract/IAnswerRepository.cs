using P.Domain.Entities;

namespace P.Domain.Abstract
{
    public interface IAnswerRepository: IGenericRepository<Answer>
    {
        void Update(Answer answer);
    }
}
