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
    public partial class KlasikSoru : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public KlasikSoru(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            if (tbKlasikSoru.Text.Length > 10)
            {
                int Id = Convert.ToInt32(Application["ExamId"]);
                var question = new Question
                {
                    Type = "Klasik",
                    ExamId = Id,
                    Content = tbKlasikSoru.Text
                };
                var exam = _unitOfWork.Exams.GetById(Id);

                _unitOfWork.Questions.Add(question);
                exam.Questions.Add(question);
                _unitOfWork.Complete();
                Response.Redirect("SoruEkle.aspx");
            }
            else Response.Write("<script>alert('Soru eklemek için gereklilikleri tamamlamalısın!')</script>");
        }
    }
}