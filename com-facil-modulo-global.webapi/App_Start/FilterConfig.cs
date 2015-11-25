using System.Web;
using System.Web.Mvc;

namespace com_facil_modulo_global.webapi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
