﻿using System.Web;
using System.Web.Mvc;

namespace XDPM_QL_TourDuLich
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
