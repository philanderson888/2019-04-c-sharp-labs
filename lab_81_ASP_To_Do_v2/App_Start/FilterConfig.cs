using System.Web;
using System.Web.Mvc;

namespace lab_81_ASP_To_Do_v2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
