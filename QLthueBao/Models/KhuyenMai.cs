namespace QLthueBao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Mo_ta { get; set; }

        public int? Id_goi_cuoc { get; set; }

        public double? Muc_giam { get; set; }

        public DateTime? TG_bat_dau { get; set; }

        public DateTime? TG_ket_thuc { get; set; }

        public string Image { get; set; }

        public virtual GoiCuoc GoiCuoc { get; set; }
    }
}
