using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class JobApplication : System.Web.UI.Page
    {
        //NO DM so create a temporary static variable for your collection
        public static List<JobApps> AppList;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (!Page.IsPostBack)
            {
                AppList = new List<JobApps>();
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            //remove any data within a control
            FullName.Text = "";
            EmailAddress.Text = "";
            PhoneNumber.Text = "";
            FullOrPartTime.ClearSelection();
            Jobs.ClearSelection();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //need to collect entered data
            string fullname = FullName.Text;
            string email = EmailAddress.Text;
            string phone = PhoneNumber.Text;
            string time = FullOrPartTime.SelectedValue;
            //create a message containing the entered data 
            string msg = string.Format("Name: {0} Email: {1} Phone: {2} Time: {3}",fullname,email,phone,time);
            //to handle the checkbox list, traverse the list and obtain the data that was selected
            //during the traverse create a string of jobs selected
            //add the job string or reject message to the other data
            string jobs = " Jobs: ";
            bool found = false;
            foreach (ListItem item in Jobs.Items)
            {
                if (item.Selected)
                {
                    //could be item.Text;
                    jobs += item.Value + " ";
                    found = true;
                }
            }
            if (!found)
            {
                jobs += " You did not select a job. Application rejected";
            }
            else
            {
                //collect the jobs applicatation into a  collection List<T>
                AppList.Add(new JobApps(fullname, email, phone, time, jobs));

            }
            //display the complete message
            Message.Text = msg + jobs;


            //display all collected applications
            JobApplicationList.DataSource = AppList;
            JobApplicationList.DataBind();
        }
    }
}