using P.Domain.Abstract;
using P.Domain.Entities;

namespace P.DataAccess.Concrete
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(DatabaseContext databaseContext) : base(databaseContext) { }

        public void Update(Course course)
        {
            _databaseContext.Entry(course);
        }
    }
}
