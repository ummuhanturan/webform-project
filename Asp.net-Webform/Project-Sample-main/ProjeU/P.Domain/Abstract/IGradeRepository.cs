using P.Domain.Entities;

namespace P.Domain.Abstract
{
    public interface IGradeRepository : IGenericRepository<Grade>
    {
        void Update(Grade grade);
    }
}
