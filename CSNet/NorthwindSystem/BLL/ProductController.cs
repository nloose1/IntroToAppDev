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

        public int Products_Add(Product item)
        {
            //at some point in time your individual product fields must be placed in an instance of the class this can be done on the web page or within this method 

            //start a transaction
            using (var context = new NorthwindContext())
            {
                //step one
                //stage th edata for exicution by the comit statement
                //staging is done in local memory
                //staging does not create an identity value; this is done at commit time 
                context.Products.Add(item);

                //step two
                //commit your staged record to the database
                //if the commiting command is successful then the new identity value will exist in your data instance
                //if the committing command is not successfull, the transaction is ROLLBACK
                context.SaveChanges();

                //optionally
                //you may decide to return the new identity value to the web page
                //if you decide to return the value then the method has a returndatatype of int else the method should be using a return datatype of void
                //SINCE the commit command worked (if you are exicuting this statement)
                //  you will find the identity value in your instance
                return item.ProductID;
            }
        }
    }
}
