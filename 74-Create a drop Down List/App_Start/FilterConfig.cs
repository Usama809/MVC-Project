using System.Web;
using System.Web.Mvc;

namespace _74_Create_a_drop_Down_List
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
