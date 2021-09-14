using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai4.Models
{
    public class Employee : KhachHang 
    {
        public new string TenKH { get; set; }
        public new string SDT { get; set; }
        public new string DiaChi { get; set; }
    }
}