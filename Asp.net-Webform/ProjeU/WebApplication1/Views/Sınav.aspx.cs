using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class Sınav : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        public Sınav(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            string examCode = Application["ExamCode"].ToString();
            var exam = _unitOfWork.Exams.FindT(x => x.examCode == examCode).FirstOrDefault().Id;
            var questions = _unitOfWork.Questions.FindT(x => x.ExamId == exam).ToList();
            foreach(var question in questions)
            {
                if(question.Type == "Klasik")
                {
                    tbKlasik.Text = question.Content;
                }
                else if(question.Type == "cokluSecmeli")
                {
                    tbCokluSecmeli.Text = question.Content;
                    var answers = _unitOfWork.Answers.FindT(x => x.questionId == question.Id).ToList();
                    foreach (var item in question.Answers)
                    {
                        cblCokluSecmeli.Items.Add(item.answerContent);

                    }
                }
                else if (question.Type == "coktanSecmeli")
                {
                    tbCoktanSecmeli.Text = question.Content;
                    var answers = _unitOfWork.Answers.FindT(x => x.questionId == question.Id).ToList();
                    //var answers = _unitOfWork.Answers.FindT(x => x.Que).ToList();
                    foreach (var item in question.Answers)
                    {
                        rblCoktanSecmeli.Items.Add(item.answerContent);
                    }
                }
            }
        }

        protected void btnComplete_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Sınavı başarıyla tamamladınız!')</script>");
            Response.Redirect("Index.aspx");
        }
    }
}