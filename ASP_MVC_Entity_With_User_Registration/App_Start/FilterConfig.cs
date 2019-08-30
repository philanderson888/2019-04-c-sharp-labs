using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_Entity_With_User_Registration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
