using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDPM_QL_TourDuLich_WinForms.BIZ
{
    public class DiaDiemDL
    {
        public DataTable layDanhSachCacDiaDiem(int maTour)
        {
            Entity.DAL.DiaDiemDL dd = new Entity.DAL.DiaDiemDL();
            return dd.layDanhSachCacDiaDiem(maTour);
        }
    }
}
