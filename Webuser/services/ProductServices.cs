using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webuser.models;

namespace Webuser.services
{
    public class ProductServices
    {
        public static void get(int gett)
        {
            Hakancontext db = new Hakancontext();
            Product product = db.Products.Find(gett);
        }


    }
}
