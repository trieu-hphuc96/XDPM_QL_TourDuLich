namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doan_ChiPhiKhac
    {
        [Key]
        public int MaDCPK { get; set; }

        public int? MaDoan { get; set; }

        [StringLength(30)]
        public string TenCPKhac { get; set; }

        public int? Gia { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual DoanDL DoanDL { get; set; }
    }
}
