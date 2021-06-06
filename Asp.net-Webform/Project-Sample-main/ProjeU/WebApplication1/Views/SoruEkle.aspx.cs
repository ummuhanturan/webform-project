using P.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class SoruEkle : System.Web.UI.Page
    {
        IUnitOfWork _unitOfWork;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public SoruEkle(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void soruEkle_Click(object sender, EventArgs e)
        {
            if (soruEkleDropdown.SelectedItem.Value == "Klasik")
            {
                Response.Redirect("KlasikSoru.aspx");
            }
            else if (soruEkleDropdown.SelectedItem.Value == "cokluSecmeli")
            {
                Response.Redirect("CokluSecmeli.aspx");
            }
            else if (soruEkleDropdown.SelectedItem.Value == "coktanSecmeli")
            {
                Response.Redirect("CoktanSecmeli.aspx");
            }
        }

        protected void btnComplete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Application["ExamId"]);
            _unitOfWork.Complete();
        }
    }
}