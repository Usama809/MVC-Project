using System.Web;
using System.Web.Mvc;

namespace _79_Non_Action_Attribute
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
