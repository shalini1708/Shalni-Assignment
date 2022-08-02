using System.Web;
using System.Web.Mvc;

namespace sec4datavalidationusingmetadata
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
