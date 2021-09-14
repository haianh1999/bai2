namespace bai4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtableEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHang", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHang", "Discriminator");
        }
    }
}
