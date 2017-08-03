using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConvertApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ConvertAppService.ConvertToWord webServiceObj = new ConvertAppService.ConvertToWord();
            String convertedString = webServiceObj.ConvertNumberToWords(txtNumber.Text.ToString());
            Session["userName"] = txtUserName.Text.ToString();
            Session["word"] = convertedString;
            Response.Redirect("DisplayPage.aspx");
        }
    }
}