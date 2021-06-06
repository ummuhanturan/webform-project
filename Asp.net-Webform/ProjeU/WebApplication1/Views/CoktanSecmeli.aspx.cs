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
    public partial class CoktanSecmeli : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public CoktanSecmeli(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void addAnswer_Click(object sender, EventArgs e)
        {
            siklarListBox.Items.Add(siklarEkle.Text);
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (siklarListBox.Items.Count >= 3 && rightAnswer.Text.Length >= 1 && soruCumlesi.Text.Length > 10)
            {
                var exam = _unitOfWork.Exams.GetById(Convert.ToInt32(Application["ExamId"]));
                Question question = new Question();
                question.Content = soruCumlesi.Text;
                question.Type = "coktanSecmeli";
                question.ExamId = Convert.ToInt32(Application["ExamId"]);
                List<Answer> answers = new List<Answer>();


                foreach (var ans in siklarListBox.Items)
                {
                    if(ans.ToString() != rightAnswer.Text)
                    {
                        var answer = new Answer
                        {
                            answerContent = ans.ToString(),
                            isTrue = false,
                            questionId = question.Id
                        };

                        answers.Add(answer);
                    }

                    else
                    {
                        var answer = new Answer
                        {
                            answerContent = ans.ToString(),
                            isTrue = true,
                            questionId = question.Id
                        };

                        answers.Add(answer);
                    }
                }

                question.Answers = answers;
                _unitOfWork.Questions.Add(question);
                exam.Questions.Add(question);
                _unitOfWork.Complete();

                Response.Redirect("SoruEkle.aspx");
            }
            else Response.Write("<script>alert('Soru eklemek için gereklilikleri tamamlamalısın!')</script>");
        }
    }
}