namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Configurations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            RenameTable(name: "dbo.ProviderProducts", newName: "Providings");
            DropForeignKey("dbo.Products", "CategoryFK", "dbo.Categories");
            RenameColumn(table: "dbo.Providings", name: "Provider_Id", newName: "ProvId");
            RenameColumn(table: "dbo.Providings", name: "Product_ProductId", newName: "ProdId");
            RenameIndex(table: "dbo.Providings", name: "IX_Product_ProductId", newName: "IX_ProdId");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider_Id", newName: "IX_ProvId");
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.MyCategories", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Products", "Adresse_City", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Providings", new[] { "ProdId", "ProvId" });
            AddForeignKey("dbo.Products", "CategoryFK", "dbo.MyCategories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryFK", "dbo.MyCategories");
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.Products", "Adresse_City", c => c.String());
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            AddPrimaryKey("dbo.Providings", new[] { "Provider_Id", "Product_ProductId" });
            RenameIndex(table: "dbo.Providings", name: "IX_ProvId", newName: "IX_Provider_Id");
            RenameIndex(table: "dbo.Providings", name: "IX_ProdId", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "ProdId", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "ProvId", newName: "Provider_Id");
            AddForeignKey("dbo.Products", "CategoryFK", "dbo.Categories", "CategoryId");
            RenameTable(name: "dbo.Providings", newName: "ProviderProducts");
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
        }
    }
}
