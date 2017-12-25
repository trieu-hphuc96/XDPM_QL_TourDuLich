namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            DoanDL_KhachHang = new HashSet<DoanDL_KhachHang>();
        }

        [Key]
        public int MaKH { get; set; }

        [StringLength(30)]
        public string HoTen { get; set; }

        public int? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string SoDT { get; set; }

        [StringLength(30)]
        public string CMND { get; set; }

        [StringLength(30)]
        public string Passport { get; set; }

        [StringLength(20)]
        public string QuocTich { get; set; }

        [StringLength(30)]
        public string DiaChi { get; set; }

        public int? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanDL_KhachHang> DoanDL_KhachHang { get; set; }
    }
}
