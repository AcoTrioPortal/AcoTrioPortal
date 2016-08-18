using System.Web;
using System.Web.Mvc;

namespace _4_BSC.Trio.BAL.WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
