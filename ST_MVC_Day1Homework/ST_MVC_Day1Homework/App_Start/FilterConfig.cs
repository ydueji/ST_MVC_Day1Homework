using System.Web;
using System.Web.Mvc;

namespace ST_MVC_Day1Homework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
