using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class GirisYap : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public GirisYap(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            var teachers = _unitOfWork.Teachers.GetAll();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var teacherS = _unitOfWork.Teachers.FindT(teacher => teacher.Email == TextBox1.Text && teacher.Password == TextBox2.Text).SingleOrDefault();

            if (teacherS != null)
            {
                Application["email"] = teacherS.Email;
                Response.Redirect("Index.aspx");
            }
            else Response.Write("<script>alert('Email veya şifre hatalı!')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("KayitOl.aspx");
        }
    }
}