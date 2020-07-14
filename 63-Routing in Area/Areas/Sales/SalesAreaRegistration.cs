using System.Web.Mvc;

namespace _63_Routing_in_Area.Areas.Sales
{
    public class SalesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Sales";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Sales_default",
                "Sales/{controller}/{action}/{id}",
                new { controller ="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}