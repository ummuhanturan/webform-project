using P.Domain.Entities;

namespace P.Domain.Abstract
{
    public interface IExamRepository : IGenericRepository<Exam>
    {
        void Update(Exam exam);
    }
}
