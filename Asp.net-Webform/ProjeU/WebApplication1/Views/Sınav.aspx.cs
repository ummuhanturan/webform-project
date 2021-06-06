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
            int examId = Convert.ToInt32(Application["ExamIdT"]);
            var exam = _unitOfWork.Exams.GetById(examId);
            foreach(var question in exam.Questions)
            {
                if(question.Type == "Klasik")
                {
                    tbKlasik.Text = question.Content;
                }
                else if(question.Type == "cokluSecmeli")
                {
                    tbCokluSecmeli.Text = question.Content;
                    foreach (var item in question.Answers)
                    {
                        cblCokluSecmeli.Items.Add(item.answerContent);
                    }
                }
                else if (question.Type == "coktanSecmeli")
                {
                    tbCoktanSecmeli.Text = question.Content;
                    foreach (var item in question.Answers)
                    {
                        rblCoktanSecmeli.Items.Add(item.answerContent);
                    }
                }
            }
        }


    }
}