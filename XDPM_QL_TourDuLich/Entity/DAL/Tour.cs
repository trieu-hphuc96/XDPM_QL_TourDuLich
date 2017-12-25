using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity.DAL
{

    public class Tour
    {
        

        QL_TourDuLichDBContext db = new QL_TourDuLichDBContext();

        public DataTable layDanhSachTour()
        {
            var tours = db.Database.SqlQuery<Models.Tour>("sp_layDanhSachTour").ToList();

            DataTable dt = List_to_DataTable.ToDataTable<Models.Tour>(tours);

            return dt;
        }
    }
}
