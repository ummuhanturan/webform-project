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
    public partial class DersEkle : System.Web.UI.Page
    {
        IUnitOfWork _unitofWork;

        public DersEkle(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Application["email"].ToString();
            var teacher = _unitofWork.Teachers.FindSingle(t => t.Email == email);
            TextBox3.Text = teacher.Name + "Hoşgeldin";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var course = new Course 
            { 
                Name = TextBox1.Text,
                CourseCode = TextBox2.Text
            };

            if(TextBox1.Text != "")
            {
                try
                {
                    _unitofWork.Courses.Add(course);
                    _unitofWork.Complete();
                    Response.Redirect(Page.Request.Url.ToString(), true);
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.InnerException);
                    Response.Write("<script>alert('Alanlar Boş Bırakılamaz!')</script >");
                    Response.Redirect(Page.Request.Url.ToString(), true);
                }
            }
        }
    }
}