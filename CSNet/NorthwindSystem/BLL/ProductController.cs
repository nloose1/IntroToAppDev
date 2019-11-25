using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Data;
#endregion

namespace NorthwindSystem.BLL
{
    public class ProductController
    {
        //using SqlQuery to do non primary key lookups
        public List<Product> Products_FindByCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                //syntax
                //context.Database.SqlQuery<T>("sqlprocname [@parameterid[,@parameterid, ...]]"
                //      [, new SqlParameter("parameterid", value)[, new SqlParameter("parameterid",value)]]);
                //examples
                //context.Database.SqlQuery<T>("sqlprocname");  no parameters
                //context.Database.SqlQuery<T>("sqlprocname @parameterid"
                //      , new SqlParameter("parameterid", value)); one parameter
                //context.Database.SqlQuery<T>("sqlprocname @parameterid,@parameterid"
                //      , new SqlParameter("parameterid", value), new SqlParameter("parameterid",value)); +1> parameters

                //the return datatype of this query is IEnumerable<T>
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetByCategories @CategoryID"
                        , new SqlParameter("CategoryID", categoryid));
                return results.ToList();
            }
        }
        public List<Product> Products_List()
        {

            using(var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }
        public Product Products_FindByID(int productid)
        {

            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }

        public int Products_Add(Product item)
        {
            //at some point in time, your individual product fields
            //    must be placed in an instance of the class
            //this can be done on the web page or within this method

            //start a transaction
            using (var context = new NorthwindContext())
            {
                //Step One
                //Stage the data for execution by the commit statement
                //Staging is done in local memory
                //Staging DOES NOT create an identity value; this is done
                //    at commit time
                context.Products.Add(item);

                //Step Two
                //commit your staged record to the database
                //IF there is any entity calidation annotation it will be executed during the .SaveChanges() processing
                //if any entity validation error is discovered, the messages are returned and the commit is aborted
                //if the committing command is successful, then the new
                //    identity value WILL exist in your data instance
                //if the committing command is NOT successful, the
                //    transaction is ROLLBACK
                context.SaveChanges();

                //optionally
                //you may decide to return the new identity value to
                //    the web page
                //if you decide to return the value, then the method has a
                //    returndatatype of int; else the method should be using
                //    a returndatatype of void
                //SINCE the commit command worked (if you are executing this statement)
                //    you will find the identity value in your instance
                return item.ProductID;

            }
        }
        //Update 
        //change the entire entity record
        //it does not matter logically that you change a value to itself
        //by chnaging the entire entity you change all fields that new to be alterd
        //the value returned is the number of rows affected
        public int Products_Update(Product item)
        {
            using (var context = new NorthwindContext())
            {
                //staging 
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                //commit and feedback(rows affected)
                return context.SaveChanges();
            }
        }

        //Delete
        //Delete (Physical) or change (logical delete so really an update) the entire entiry record
        //the value returned is the number of rows affected
        public int Products_Delete(int productid)
        {
            using (var context = new NorthwindContext())
            {
                ////Physical Delete
                ////the physical removal of a record from a database

                ////locate the instance of the entity to be removed
                //var existing = context.Products.Find(productid);
                ////optional check to see if it is there
                ////if not throw an exception
                ////this process can also be handled on the web form during feedback
                //if (existing == null)
                //{
                //    throw new Exception("Record has been removed from database");
                //}

                ////stage
                //context.Products.Remove(existing);
                ////Commit and feedback
                //return context.SaveChanges();

                //Logical Delete
                //you normally set a property to a spesific value to indicate the record should be concidered gone
                //this is actually an update of the record

                //locate the instance of the entity to be changed
                var existing = context.Products.Find(productid);
                //set the property to the specific value
                existing.Discontinued = true;
                //stage and update
                context.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                //commit the feeback
                return context.SaveChanges();
            }
        }
    }
}
