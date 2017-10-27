using System.Web;
using System.Web.Mvc;

namespace S00112276Rad2017Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
