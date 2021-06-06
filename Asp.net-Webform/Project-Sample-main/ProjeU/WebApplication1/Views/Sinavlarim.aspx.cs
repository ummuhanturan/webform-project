using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class Sinavlarim : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        public Sinavlarim(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadExams();
        }

        private void LoadExams()
        {
            var teacherEmail = Application["email"].ToString();
            var teacherId = _unitOfWork.Teachers.GetIdByEmail(teacherEmail).Id;
            var teacherExams = _unitOfWork.Exams.FindT(x => x.TeacherId == teacherId).ToList();

            ListView1.DataSource = teacherExams;
            ListView1.DataBind();
        }

    }
}