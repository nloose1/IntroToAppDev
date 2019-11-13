using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional namespaces
using NorthwindSystem.BLL;
using NorthwindSystem.Data;
#endregion

namespace WebApp.SamplePages
{
    public partial class SimpleQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //empty old message
            MessageLabel.Text = "";
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegionIDArg.Text))
            {
                MessageLabel.Text = "Enter a region id value";
            }
            else
            {
                int regionid = 0;
                if (!int.TryParse(RegionIDArg.Text,out regionid))
                {
                    MessageLabel.Text = "Region ID must be a number";
                }
                else
                {
                    if (regionid<1)
                    {
                        MessageLabel.Text = "Region ID must be a whole number greater than 0";
                    }
                    else
                    {
                        //anytime you plan on leaving your web app project to go to another project you MUST use trycatch
                        try
                        {
                            //Standard query lookup
                            //steps
                            //create a reciving data variable
                            //create an instance of the controller class you are going to make your request to
                            //issue your request
                            //check your results
                            // a) List<T> use .Count
                            // b) single record use ==null
                            //display according to your results
                            Region info = null;
                            RegionController sysmgr = new RegionController();
                            info = sysmgr.Regions_FindByID(regionid);
                            if (info == null)
                            {
                                MessageLabel.Text = "Region id not found";
                                RegionID.Text = "";
                                RegionDescription.Text = "";
                            }
                            else
                            {
                                RegionID.Text = info.RegionID.ToString();
                                RegionDescription.Text = info.RegionDescription;
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageLabel.Text = ex.Message;
                        }
                        
                    }
                }
            }
        }
    }
}