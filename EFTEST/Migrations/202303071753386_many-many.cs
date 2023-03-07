namespace EFTEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manymany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryAdi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductAdı = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Product_ProductId = c.Int(nullable: false),
                        Category_CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ProductId, t.Category_CategoryId })
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .Index(t => t.Product_ProductId)
                .Index(t => t.Category_CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductCategories", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ProductCategories", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ProductCategories", new[] { "Category_CategoryId" });
            DropIndex("dbo.ProductCategories", new[] { "Product_ProductId" });
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
