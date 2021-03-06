using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        ICourseRepository Courses { get; }
        IExamRepository Exams { get; }
        IGradeRepository Grades { get; }
        IQuestionRepository Questions { get; }
        IStudentRepository Students { get; }
        ITeacherRepository Teachers { get; }
        IAnswerRepository Answers { get; }
        int Complete();
    }
}
