using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class UserReg : System.Web.UI.Page
    {
        public static List<UserRegistration> Entries;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (!Page.IsPostBack)
            {
                Entries = new List<UserRegistration>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (Terms.Checked)
                {
                    UserRegistration theEntry = new UserRegistration();

                    Entries.Add(new UserRegistration(FirstName.Text, LastName.Text, UserName.Text, Email.Text, Password.Text));

                    RegList.DataSource = Entries;
                    RegList.DataBind();
                }
                else
                {
                    Message.Text = "You did not agree to the contest terms. Entry rejected.";
                }
            }
        }
    }
}