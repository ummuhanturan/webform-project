using P.Domain.Entities;

namespace P.Domain.Abstract
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        void Update(Course course);
    }
}
