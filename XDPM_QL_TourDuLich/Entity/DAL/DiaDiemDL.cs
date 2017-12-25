using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DAL
{
    public class DiaDiemDL
    {
        QL_TourDuLichDBContext db = new QL_TourDuLichDBContext();

        public DataTable layDanhSachCacDiaDiem(int maTour)
        {
            object[] parameters = {
                           new SqlParameter("@MaTour",maTour)
                       };

            var tours = db.Database.SqlQuery<Models.DiaDiemDL>("sp_layDanhSachCacDiaDiem @MaTour", parameters).ToList();

            DataTable dt = List_to_DataTable.ToDataTable<Models.DiaDiemDL>(tours);

            return dt;
        }
    }
}
