﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDPM_QL_TourDuLich_WinForms.BIZ
{
    public class Tour
    {
        public DataTable layDanhSachTour()
        {
            Entity.DAL.Tour tour = new Entity.DAL.Tour();
            return tour.layDanhSachTour();
        }

        public DataTable timkiemDanhSachTour(string keyword)
        {
            Entity.DAL.Tour tour = new Entity.DAL.Tour();
            return tour.timkiemDanhSachTour(keyword);
        }
    }
}
