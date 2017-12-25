namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doan_KhachSan
    {
        [Key]
        public int MaDKS { get; set; }

        public int MaDoan { get; set; }

        public int MaDD { get; set; }

        [StringLength(30)]
        public string TenKS { get; set; }

        public int? Gia { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual DiaDiemDL DiaDiemDL { get; set; }

        public virtual DoanDL DoanDL { get; set; }
    }
}
