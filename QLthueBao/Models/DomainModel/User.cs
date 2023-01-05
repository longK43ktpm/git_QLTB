namespace QLthueBao.Models.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            GDGoiCuocs = new HashSet<GDGoiCuoc>();
            GDNapDienThoais = new HashSet<GDNapDienThoai>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Phone_number { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? Created { get; set; }

        public int? Tai_khoan_goc { get; set; }

        public int Id_nha_mang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GDGoiCuoc> GDGoiCuocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GDNapDienThoai> GDNapDienThoais { get; set; }

        public virtual NhaMang NhaMang { get; set; }
    }
}
