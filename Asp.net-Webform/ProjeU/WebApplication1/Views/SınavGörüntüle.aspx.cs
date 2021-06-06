using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class SınavGörüntüle : System.Web.UI.Page
    {
        private readonly IUnitOfWork _unitOfWork;

        public SınavGörüntüle(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void redirectToExam_Click(object sender, EventArgs e)
        {
            Application["examIdT"] = _unitOfWork.Exams.getExamByCode(examCode.Text).Id;
            Response.Redirect("Sınav.aspx");
        }
    }
}