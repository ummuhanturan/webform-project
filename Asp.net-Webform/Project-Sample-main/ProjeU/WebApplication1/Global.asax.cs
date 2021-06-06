using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using P.DataAccess.Concrete;
using P.DataAccess.UnitOfWork;
using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = this.AddUnity();

            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            container.RegisterType<ITeacherRepository, TeacherRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<IExamRepository, ExamRepository>();
            container.RegisterType<IGradeRepository, GradeRepository>();
            container.RegisterType<IQuestionRepository, QuestionRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ITeacherRepository, TeacherRepository>();
        }
    }
}