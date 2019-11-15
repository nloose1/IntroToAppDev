using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.Data;
using NorthwindSystem.DAL;
#endregion

namespace NorthwindSystem.BLL
{
    public class CategoryController
    {
        public List<Category> Categories_List()
        {
            using(var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
