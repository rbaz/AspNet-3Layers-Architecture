using HDBellWebUI.Attributes;
using System.Web;
using System.Web.Mvc;

namespace HDBellWebUI
{
    public class FilterConfig
    {
        //public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        //{
        //    filters.Add(new HandleErrorAttribute());            
        //}

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LocalizationAttribute("en"), 0);
        }
    }
}
