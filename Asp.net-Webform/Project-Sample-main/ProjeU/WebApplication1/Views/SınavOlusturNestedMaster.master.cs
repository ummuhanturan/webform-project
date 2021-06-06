using P.Domain.Abstract;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class SınavOlusturNestedMaster : System.Web.UI.MasterPage
    {
        private readonly IUnitOfWork _unitOfWork;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public SınavOlusturNestedMaster(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 3 && tbDersAdi.Text.Length > 4)
            {
                var course = _unitOfWork.Courses.FindT(x => x.CourseCode == tbDersAdi.Text).SingleOrDefault();
                var teacherEmail = Application["email"].ToString();
                var teacher = _unitOfWork.Teachers.GetIdByEmail(teacherEmail);
                var exam = new Exam
                {
                    Name = TextBox1.Text,
                    CourseId = course.Id,
                    TeacherId = teacher.Id
                };

                _unitOfWork.Exams.Add(exam);
                _unitOfWork.Complete();
                Application["ExamId"] = exam.Id.ToString();

                Response.Redirect("SoruEkle.aspx");

            }
            else Response.Write("<script>alert('Yeterli sayıda karakter giriniz!)");
        }

        protected void finishExam_Click(object sender, EventArgs e)
        {
            if (Application["ExamId"].ToString() != null)
            {
                _unitOfWork.Complete();
            }
        }
    }
}