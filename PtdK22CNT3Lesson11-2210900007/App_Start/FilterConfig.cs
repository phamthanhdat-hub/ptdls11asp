using System.Web;
using System.Web.Mvc;

namespace PtdK22CNT3Lesson11_2210900007
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
