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
    public class RegionController
    {
        //EntityFramework realizes that sertain requests for data are common
        //EntityFramework has created methods that can be called to do the common requests

        //method that will return all Region records
        public List<Region> Regions_List()
        {
            //create an instance of the context class that will handle the data request
            //Most of CRUD requires using a transaction
            //to ensure that your data request is handled as a transaction we will encase all controller action within a transaction
            using(var context = new NorthwindContext())
            {
                return context.Regions.ToList();
            }
        }


        //method that will return a specific Region record based on its primary key

        public Region Regions_FindByID(int regionid)
        {
            //transaction code
            using (var context = new NorthwindContext())
            {
                return context.Regions.Find(regionid);
            }
        }

    }
}
