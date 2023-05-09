using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webuser.models;

namespace Webuser.services
{
    public class CityServise
    {
        public static List<City> GetAll()
        {
            Hakancontext context = new Hakancontext();
            List<City> list = context.Cities.ToList();

            return list;
        }
    }
}
