namespace bai4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatHang")]
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            ChiTietNhaps = new HashSet<ChiTietNhap>();
        }

        [Key]
        [StringLength(10)]
        public string MaMH { get; set; }

        [StringLength(100)]
        public string TenMH { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        [StringLength(255)]
        public string MauSac { get; set; }

        [StringLength(50)]
        public string NhaSX { get; set; }

        [StringLength(10)]
        public string DonViTinh { get; set; }

        public double? DonGiaBan { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
    }
}
