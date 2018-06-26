using System.Web;
using System.Web.Mvc;

namespace Localization_and_internalization_C_sharp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
