using P.Domain.Abstract;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class KayitOl : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        protected void Page_Load()
        {
        }

        public KayitOl(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher
            {
                Name = TextBox4.Text,
                Surname = TextBox5.Text,
                Email = TextBox3.Text,
                Password = TextBox2.Text
            };

            if (TextBox4.Text != "")
            {
                try
                {
                    _unitOfWork.Teachers.Add(teacher);
                    _unitOfWork.Complete();
                    Response.Redirect("GirisYap.aspx");
                }
                catch(Exception et)
                {
                    Response.Write(et.InnerException);
                }
            }
            else
            {
                Response.Write("<script>alert('Alanlar Boş Bırakılamaz!')</script >");
                Response.Redirect(Page.Request.Url.ToString(), true);
            }

        }
    }
}