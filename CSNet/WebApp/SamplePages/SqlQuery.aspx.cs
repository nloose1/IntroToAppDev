using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using NorthwindSystem.BLL;
using NorthwindSystem.Data;
#endregion

namespace WebApp.SamplePages
{
    public partial class SqlQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            if (!Page.IsPostBack)
            {
                //you may need to refresh the list at another place of this page
                BindCategoryList();
            }
        }
        protected void BindCategoryList()
        {
            //standrd lookup 
            try
            {
                CategoryController sysmgr = new CategoryController();
                List<Category> info = null;
                info = sysmgr.Categories_List();
                info.Sort((x, y) => x.CategoryName.CompareTo(y.CategoryName));
                CategoryList.DataSource = info;
                CategoryList.DataTextField = nameof(Category.CategoryName);
                CategoryList.DataValueField = nameof(Category.CategoryID);
                CategoryList.DataBind();
                CategoryList.Items.Insert(0, "Select...");
            }
            catch (Exception ex)
            {

                MessageLabel.Text = ex.Message;
            }
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            if(CategoryList.SelectedIndex == 0)
            {
                MessageLabel.Text = "Must select a category to view its products";
            }
            else
            {
                try
                {
                    ProductController sysmgr = new ProductController();
                    List<Product> info = null;
                    info = sysmgr.Products_FindByCategory(int.Parse(CategoryList.SelectedValue));
                    info.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
                    ProductList.DataSource = info;
                    ProductList.DataBind();
                }
                catch (Exception ex)
                {

                    MessageLabel.Text = ex.Message;
                }
            }
        }
    }
}