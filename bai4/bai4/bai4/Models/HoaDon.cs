namespace bai4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBan { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
