using System.Web;
using System.Web.Mvc;

namespace VS2013MVC5UsingCS6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
