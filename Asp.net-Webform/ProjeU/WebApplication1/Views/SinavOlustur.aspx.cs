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
    public partial class SınavOlustur : System.Web.UI.Page
    {
        IUnitOfWork _unitOfWork;

        public SınavOlustur(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedValue == "Klasik")
            {
                Klasik.Visible = true;
                CS.Visible = false;
                CLS.Visible = false;
            }
            else if(RadioButtonList1.SelectedValue == "Çoktan Seçmeli")
            {
                CS.Visible = true;
                Klasik.Visible = false;
                CLS.Visible = false;
            }
            else
            {
                CLS.Visible = true;
                CS.Visible = false;
                Klasik.Visible = false;
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TextBox3.Text);
            var answer = new WrongAnswer
            {
                RightAnswer = TextBox3.Text,
                
            };
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var question = new Question()
            {
                Content = TextBox1.Text,
                Type = "Klasik"
            };
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var question = new Question()
            {
                Content = TextBox1.Text,
                Type = "Çoktan Seçmeli"
            };
            _unitOfWork.Questions.Add(question);
        }
    }
}