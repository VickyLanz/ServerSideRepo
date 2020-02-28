using System.Web;
using System.Web.Mvc;

namespace ErrorHandlingMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
              filters.Add(new HandleErrorAttribute());
            filters.Add(new CutomError());

        }
    }
}
