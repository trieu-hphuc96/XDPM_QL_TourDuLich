namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanDL")]
    public partial class DoanDL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoanDL()
        {
            Doan_ChiPhiKhac = new HashSet<Doan_ChiPhiKhac>();
            Doan_KhachSan = new HashSet<Doan_KhachSan>();
            Doan_PhuongTien = new HashSet<Doan_PhuongTien>();
            Doan_QuanAn = new HashSet<Doan_QuanAn>();
            DoanDL_KhachHang = new HashSet<DoanDL_KhachHang>();
            DoanDL_NhanVien = new HashSet<DoanDL_NhanVien>();
        }

        [Key]
        public int MaDoan { get; set; }

        public int MaTour { get; set; }

        [StringLength(30)]
        public string TenDoan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGioKhoiHanh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGioKetThuc { get; set; }

        public int? SLKhach { get; set; }

        public int? SLNV { get; set; }

        public string NoiDungHanhTrinh { get; set; }

        public int? TongCPKS { get; set; }

        public int? TongCPPT { get; set; }

        public int? TongCPBA { get; set; }

        public int? TongCPKhac { get; set; }

        public int? MaTourGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doan_ChiPhiKhac> Doan_ChiPhiKhac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doan_KhachSan> Doan_KhachSan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doan_PhuongTien> Doan_PhuongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doan_QuanAn> Doan_QuanAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanDL_KhachHang> DoanDL_KhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanDL_NhanVien> DoanDL_NhanVien { get; set; }
    }
}
