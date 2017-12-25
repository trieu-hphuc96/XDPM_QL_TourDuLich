namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaDiemDL")]
    public partial class DiaDiemDL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiaDiemDL()
        {
            Doan_KhachSan = new HashSet<Doan_KhachSan>();
            Doan_QuanAn = new HashSet<Doan_QuanAn>();
            Tour_DiaDiemDL = new HashSet<Tour_DiaDiemDL>();
        }

        [Key]
        public int MaDD { get; set; }

        [StringLength(30)]
        public string TenDD { get; set; }

        public int? TinhThanh { get; set; }

        [StringLength(30)]
        public string QuocGia { get; set; }

        public virtual TinhThanh TinhThanh1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doan_KhachSan> Doan_KhachSan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doan_QuanAn> Doan_QuanAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_DiaDiemDL> Tour_DiaDiemDL { get; set; }
    }
}
