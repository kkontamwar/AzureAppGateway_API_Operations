using System.Web;
using System.Web.Mvc;

namespace AzureAppGateway_Operation_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
