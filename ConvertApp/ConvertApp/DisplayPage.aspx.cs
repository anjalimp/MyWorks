using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConvertApp
{
    public partial class DisplayPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = (string) Session["userName"];
            lblWord.Text = (string) Session["word"];
        }
    }
}