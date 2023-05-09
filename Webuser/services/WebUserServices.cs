using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webuser.models;

namespace Webuser.services
{
    public class WebUserServices
    {
        public static bool Add(WebUser webUser)
        {
            try
            {
                Hakancontext hakancontext = new Hakancontext();

                hakancontext.Users.Add(webUser);
                hakancontext.SaveChanges();
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
                     

        }



    }
}
