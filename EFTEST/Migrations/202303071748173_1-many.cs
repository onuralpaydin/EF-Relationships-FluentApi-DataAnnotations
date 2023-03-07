namespace EFTEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1many : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Insan",
                c => new
                    {
                        InsanId = c.Int(nullable: false, identity: true),
                        InsanAdi = c.String(),
                        AyakkabiBaglantiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InsanId);
            
            CreateTable(
                "dbo.Ayakkabis",
                c => new
                    {
                        AyakkabiId = c.Int(nullable: false, identity: true),
                        AyakkabiMarka = c.String(),
                        Insan_InsanId = c.Int(),
                    })
                .PrimaryKey(t => t.AyakkabiId)
                .ForeignKey("dbo.tbl_Insan", t => t.Insan_InsanId)
                .Index(t => t.Insan_InsanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ayakkabis", "Insan_InsanId", "dbo.tbl_Insan");
            DropIndex("dbo.Ayakkabis", new[] { "Insan_InsanId" });
            DropTable("dbo.Ayakkabis");
            DropTable("dbo.tbl_Insan");
        }
    }
}
