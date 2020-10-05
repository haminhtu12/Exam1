using System.Web;
using System.Web.Mvc;

namespace EXAM_ASP.NET1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
