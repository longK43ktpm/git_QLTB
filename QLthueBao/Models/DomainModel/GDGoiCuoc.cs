namespace QLthueBao.Models.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GDGoiCuoc")]
    public partial class GDGoiCuoc
    {
        public int Id { get; set; }

        public int User_id { get; set; }

        public int? Tong_tien { get; set; }

        public DateTime? TG_dang_ky { get; set; }

        public DateTime? TG_het_han { get; set; }

        public int Id_goi_cuoc { get; set; }

        public int? So_luong { get; set; }

        public virtual GoiCuoc GoiCuoc { get; set; }

        public virtual User User { get; set; }
    }
}
