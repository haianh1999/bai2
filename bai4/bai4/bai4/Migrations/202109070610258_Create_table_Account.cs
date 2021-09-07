namespace bai4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        TenTK = c.String(nullable: false, maxLength: 20, unicode: false),
                        MatKhau = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.TenTK);
            
            CreateTable(
                "dbo.ChiTietNhap",
                c => new
                    {
                        MaN = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaMH = c.String(nullable: false, maxLength: 10, unicode: false),
                        SoLuong = c.Int(),
                        GiaNhap = c.Double(),
                    })
                .PrimaryKey(t => new { t.MaN, t.MaMH })
                .ForeignKey("dbo.MatHang", t => t.MaMH, cascadeDelete: true)
                .ForeignKey("dbo.NhapHang", t => t.MaN, cascadeDelete: true)
                .Index(t => t.MaN)
                .Index(t => t.MaMH);
            
            CreateTable(
                "dbo.MatHang",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenMH = c.String(maxLength: 100),
                        HinhAnh = c.Binary(storeType: "image"),
                        MauSac = c.String(maxLength: 255),
                        NhaSX = c.String(maxLength: 50),
                        DonViTinh = c.String(maxLength: 10),
                        DonGiaBan = c.Double(),
                        SoLuong = c.Int(),
                        GhiChu = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.MaMH);
            
            CreateTable(
                "dbo.NhapHang",
                c => new
                    {
                        MaN = c.String(nullable: false, maxLength: 10, unicode: false),
                        NhaCungCap = c.String(maxLength: 50),
                        NgayNhap = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.MaN);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaKH = c.String(maxLength: 10, unicode: false),
                        NgayBan = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.KhachHang", t => t.MaKH, cascadeDelete: true)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenKH = c.String(maxLength: 50),
                        SDT = c.String(maxLength: 10, unicode: false),
                        DiaChi = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDon", "MaKH", "dbo.KhachHang");
            DropForeignKey("dbo.ChiTietNhap", "MaN", "dbo.NhapHang");
            DropForeignKey("dbo.ChiTietNhap", "MaMH", "dbo.MatHang");
            DropIndex("dbo.HoaDon", new[] { "MaKH" });
            DropIndex("dbo.ChiTietNhap", new[] { "MaMH" });
            DropIndex("dbo.ChiTietNhap", new[] { "MaN" });
            DropTable("dbo.KhachHang");
            DropTable("dbo.HoaDon");
            DropTable("dbo.NhapHang");
            DropTable("dbo.MatHang");
            DropTable("dbo.ChiTietNhap");
            DropTable("dbo.Account");
        }
    }
}
