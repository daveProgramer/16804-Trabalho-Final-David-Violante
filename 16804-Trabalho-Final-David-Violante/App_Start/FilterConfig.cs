using System.Web;
using System.Web.Mvc;

namespace _16804_Trabalho_Final_David_Violante
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
