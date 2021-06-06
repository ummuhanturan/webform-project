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
    public partial class CokluSecmeli : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public CokluSecmeli(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void addAnswer_Click(object sender, EventArgs e)
        {
            siklarListBox.Items.Add(siklarEkle.Text);
        }

        protected void addrightAns_Click(object sender, EventArgs e)
        {
            dogruCevaplarListBox.Items.Add(rightAnswer.Text);
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (questionTB.Text.Length >= 10 && siklarListBox.Items.Count >= 3 && dogruCevaplarListBox.Items.Count >= 1)
            {
                int Id = Convert.ToInt32(Application["ExamId"]);
                var exam = _unitOfWork.Exams.GetById(Id);

                Question question = new Question();
                question.Type = "cokluSecmeli";
                question.Content = questionTB.Text;
                question.ExamId = Id;

                List<Answer> answers = new List<Answer>();

                foreach (var ans in siklarListBox.Items)
                {
                    foreach(var rightAnswer in dogruCevaplarListBox.Items)
                    {
                        if(ans.ToString() == rightAnswer.ToString())
                        {
                            var answer = new Answer
                            {
                                answerContent = ans.ToString(),
                                isTrue = true,
                                questionId = question.Id
                            };

                            _unitOfWork.Answers.Add(answer);
                            //question.Answers.Add(answer);
                            answers.Add(answer);
                        }
                        else
                        {
                            var answer = new Answer
                            {
                                answerContent = ans.ToString(),
                                isTrue = false,
                                questionId = question.Id
                            };
                            _unitOfWork.Answers.Add(answer);
                            answers.Add(answer);
                            //question.Answers.Add(answer);
                        }
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