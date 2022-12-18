namespace QLthueBao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GDNapDienThoai")]
    public partial class GDNapDienThoai
    {
        public int Id { get; set; }

        public int User_id { get; set; }

        public int? So_tien_nap { get; set; }

        public DateTime? Thoi_gian { get; set; }

        public virtual User User { get; set; }
    }
}
