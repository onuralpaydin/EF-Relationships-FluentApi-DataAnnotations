namespace EFTEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kisis",
                c => new
                    {
                        KisiId = c.Int(nullable: false, identity: true),
                        KisiAdi = c.String(),
                    })
                .PrimaryKey(t => t.KisiId);
            
            CreateTable(
                "dbo.TcKimliks",
                c => new
                    {
                        TcKimlikId = c.Int(nullable: false),
                        TcKimlikNo = c.String(),
                    })
                .PrimaryKey(t => t.TcKimlikId)
                .ForeignKey("dbo.Kisis", t => t.TcKimlikId)
                .Index(t => t.TcKimlikId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TcKimliks", "TcKimlikId", "dbo.Kisis");
            DropIndex("dbo.TcKimliks", new[] { "TcKimlikId" });
            DropTable("dbo.TcKimliks");
            DropTable("dbo.Kisis");
        }
    }
}
