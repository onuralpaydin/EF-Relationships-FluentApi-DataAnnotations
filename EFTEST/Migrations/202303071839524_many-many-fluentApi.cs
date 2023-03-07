namespace EFTEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manymanyfluentApi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cocuks",
                c => new
                    {
                        CocukId = c.Int(nullable: false, identity: true),
                        CocukName = c.String(),
                    })
                .PrimaryKey(t => t.CocukId);
            
            CreateTable(
                "dbo.Sinifis",
                c => new
                    {
                        SinifiId = c.Int(nullable: false, identity: true),
                        SinifiName = c.String(),
                    })
                .PrimaryKey(t => t.SinifiId);
            
            CreateTable(
                "dbo.CocugunSinifi",
                c => new
                    {
                        StudentRefId = c.Int(nullable: false),
                        CourseRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentRefId, t.CourseRefId })
                .ForeignKey("dbo.Cocuks", t => t.StudentRefId, cascadeDelete: true)
                .ForeignKey("dbo.Sinifis", t => t.CourseRefId, cascadeDelete: true)
                .Index(t => t.StudentRefId)
                .Index(t => t.CourseRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CocugunSinifi", "CourseRefId", "dbo.Sinifis");
            DropForeignKey("dbo.CocugunSinifi", "StudentRefId", "dbo.Cocuks");
            DropIndex("dbo.CocugunSinifi", new[] { "CourseRefId" });
            DropIndex("dbo.CocugunSinifi", new[] { "StudentRefId" });
            DropTable("dbo.CocugunSinifi");
            DropTable("dbo.Sinifis");
            DropTable("dbo.Cocuks");
        }
    }
}
