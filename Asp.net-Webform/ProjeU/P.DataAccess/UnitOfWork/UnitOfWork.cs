using P.DataAccess.Concrete;
using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            Answers = new AnswerRepository(_databaseContext);
            Courses = new CourseRepository(_databaseContext);
            Exams = new ExamRepository(_databaseContext);
            Grades = new GradeRepository(_databaseContext);
            Questions = new QuestionRepository(_databaseContext);
            Students = new StudentRepository(_databaseContext);
            Teachers = new TeacherRepository(_databaseContext);
        }
        public IAnswerRepository Answers { get; private set; }

        public ICourseRepository Courses { get; private set; }

        public IExamRepository Exams { get; private set; }

        public IGradeRepository Grades { get; private set; }

        public IQuestionRepository Questions { get; private set; }

        public IStudentRepository Students { get; private set; }

        public ITeacherRepository Teachers { get; private set; }

        public int Complete()
        {
            return _databaseContext.SaveChanges();
        }

        public void Dispose()
        {
            _databaseContext.Dispose();
        }
    }
}
