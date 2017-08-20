using System.Web;
using System.Web.Mvc;

namespace TheoryOfProgramming
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
