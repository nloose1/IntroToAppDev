using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.Data;
using NorthwindSystem.DAL;
using System.Data.SqlClient;
#endregion

namespace NorthwindSystem.BLL
{
    public class ProductController
    {
        //this lookup technique will be used for any non primary key lookup
        public List<Product> Products_FindByCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                //syntax
                //context.Database.SqlQuery<T>("sqlprocname [@parameterid[,@parameterid,...]]" [, new SqlParameter("parameterid", value)[, new SqlParameter("paramerterid",value),...]);
                //Examples
                //context.Database.SqlQuery<T>("sqlprocname"); //NO parameters
                //context.Database.SqlQuery<T>("sqlprocname @parameterid" , new SqlParameter("Parameterid",value)); one perameter
                //context.Database.SqlQuery<T>("sqlprocname @parameterid" , new SqlParameter("Parameterid",value) , new SqlParameter("Parameterid",value)); multiple perameters

                //the datatype of the return sql data is IEnumerable<T>
                IEnumerable <Product> results= context.Database.SqlQuery<Product>("Products_GetByCategories @CategoryID" , new SqlParameter("CategoryID", categoryid));

                return results.ToList();

            }
        }
        public List<Product> Products_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Products_FindByID(int productid)
        {
            using(var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }
    }
}
