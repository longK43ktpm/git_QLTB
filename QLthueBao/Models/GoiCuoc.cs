namespace QLthueBao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoiCuoc")]
    public partial class GoiCuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoiCuoc()
        {
            GDGoiCuocs = new HashSet<GDGoiCuoc>();
            KhuyenMais = new HashSet<KhuyenMai>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Gia { get; set; }

        public TimeSpan Thoi_han { get; set; }

        public int? Luu_luong { get; set; }

        public string Image { get; set; }

        public int? Luot_mua { get; set; }

        public int Id_Loai_cuoc { get; set; }

        public bool? Trang_thai { get; set; }

        public bool? Tu_gia_han { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GDGoiCuoc> GDGoiCuocs { get; set; }

        public virtual LoaiGoiCuoc LoaiGoiCuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
    }
}
