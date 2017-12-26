using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDPM_QL_TourDuLich_WinForms.BIZ
{
    public class DoanDL
    {
        public DataTable layThongKeChiPhiKhachSan(int matour,  DateTime tungay, DateTime denngay)
        {
            Entity.DAL.DoanDL doandl = new Entity.DAL.DoanDL();
            return doandl.layThongKeChiPhiKhachSan(matour, tungay, denngay);
        }

        public DataTable layThongKeDoanhThu(int matour, DateTime tungay, DateTime denngay)
        {
            Entity.DAL.DoanDL doandl = new Entity.DAL.DoanDL();
            return doandl.layThongKeDoanhThu(matour, tungay, denngay);
        }

        public DataTable layThongKeTinhHinh(int matour)
        {
            Entity.DAL.DoanDL doandl = new Entity.DAL.DoanDL();
            return doandl.layThongKeTinhHinh(matour);
        }
    }
}
