namespace EFTEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1ManyFluentApi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notus",
                c => new
                    {
                        NotuId = c.Int(nullable: false, identity: true),
                        NotuName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.NotuId);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        OgrenciId = c.Int(nullable: false, identity: true),
                        OgrenciName = c.String(),
                        OgrenciNotuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgrenciId)
                .ForeignKey("dbo.Notus", t => t.OgrenciNotuId, cascadeDelete: true)
                .Index(t => t.OgrenciNotuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogrencis", "OgrenciNotuId", "dbo.Notus");
            DropIndex("dbo.Ogrencis", new[] { "OgrenciNotuId" });
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Notus");
        }
    }
}
