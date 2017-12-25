namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gia_Tour
    {
        [Key]
        public int MaGia { get; set; }

        public int MaTour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianKT { get; set; }

        public int? Gia { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
