using P.Domain.Entities;

namespace P.Domain.Abstract
{
    public interface ITeacherRepository : IGenericRepository<Teacher>
    { 
        void Update(Teacher teacher);
    }
}
