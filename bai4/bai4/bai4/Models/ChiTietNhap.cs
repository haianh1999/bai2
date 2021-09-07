namespace bai4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietNhap")]
    public partial class ChiTietNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMH { get; set; }

        public int? SoLuong { get; set; }

        public double? GiaNhap { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual NhapHang NhapHang { get; set; }
    }
}
