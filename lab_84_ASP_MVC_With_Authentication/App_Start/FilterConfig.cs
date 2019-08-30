using System.Web;
using System.Web.Mvc;

namespace lab_84_ASP_MVC_With_Authentication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
