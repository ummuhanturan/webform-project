﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class SınavaGir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSınav_Click(object sender, EventArgs e)
        {
            Application["examCode"] = examCode.Text;
            Response.Redirect("Sınav.aspx");
        }
    }
}