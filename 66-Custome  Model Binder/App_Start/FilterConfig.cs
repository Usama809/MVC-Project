using System.Web;
using System.Web.Mvc;

namespace _66_Custome__Model_Binder
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
