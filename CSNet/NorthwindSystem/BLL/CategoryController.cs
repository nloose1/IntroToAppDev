using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Data;
using System.ComponentModel;//to expose classes and methods to ODS
#endregion

namespace NorthwindSystem.BLL
{
    //expose this class to the ObjectDataSource wizard
    [DataObject]
    public class CategoryController
    {
        //expose a mothod to the ODS wizard
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Category> Categories_List()
        {
            using(var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category Categories_FindByID(int categoryid)
        {
            using(var context = new NorthwindContext())
            {
                return context.Categories.Find(categoryid);
            }
        }
    }
}
