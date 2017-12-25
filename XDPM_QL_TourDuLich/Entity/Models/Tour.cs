namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            Gia_Tour = new HashSet<Gia_Tour>();
            Tour_DiaDiemDL = new HashSet<Tour_DiaDiemDL>();
        }

        [Key]
        public int MaTour { get; set; }

        [StringLength(30)]
        public string TenTour { get; set; }

        public int? Gia { get; set; }

        public int? SoDiemDuLich { get; set; }

        public int? SLNgay { get; set; }

        public int? LoaiHinhDL { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gia_Tour> Gia_Tour { get; set; }

        public virtual LoaiHinhDL LoaiHinhDL1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_DiaDiemDL> Tour_DiaDiemDL { get; set; }
    }
}
