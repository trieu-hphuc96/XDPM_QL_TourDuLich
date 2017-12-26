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
    public class DoanDL
    {
        QL_TourDuLichDBContext db = new QL_TourDuLichDBContext();

        public DataTable layThongKeChiPhiKhachSan(int matour, DateTime tungay, DateTime denngay)
        {
            object[] parameters = {
                           new SqlParameter("@MaTour",matour),
                           new SqlParameter("@TuNgay",tungay),
                           new SqlParameter("@DenNgay",denngay)
                       };

            var data = db.Database.SqlQuery<Models.ThongKeChiPhiKhachSan>("sp_layThongKeChiPhiKhachSan @MaTour,@TuNgay,@DenNgay", parameters).ToList();

            DataTable dt = List_to_DataTable.ToDataTable<Models.ThongKeChiPhiKhachSan>(data);

            return dt;
        }

        public DataTable layThongKeDoanhThu(int matour, DateTime tungay, DateTime denngay)
        {
            object[] parameters = {
                           new SqlParameter("@MaTour",matour),
                           new SqlParameter("@TuNgay",tungay),
                           new SqlParameter("@DenNgay",denngay)
                       };

            var data = db.Database.SqlQuery<Models.ThongKeDoanhThu>("sp_layThongKeDoanhThu @MaTour,@TuNgay,@DenNgay", parameters).ToList();

            DataTable dt = List_to_DataTable.ToDataTable<Models.ThongKeDoanhThu>(data);

            return dt;
        }

        public DataTable layThongKeTinhHinh(int matour)
        {
            object[] parameters = {
                           new SqlParameter("@MaTour",matour),
                       };

            var data = db.Database.SqlQuery<Models.ThongKeTinhHinh>("sp_layThongKeTinhHinh @MaTour", parameters).ToList();

            DataTable dt = List_to_DataTable.ToDataTable<Models.ThongKeTinhHinh>(data);

            return dt;
        }
    }
}
