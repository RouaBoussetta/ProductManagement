namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Annotations : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "CategoryFK");
            RenameIndex(table: "dbo.Products", name: "IX_CategoryId", newName: "IX_CategoryFK");
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Providers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Providers", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Providers", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Providers", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Providers", "Email", c => c.String());
            AlterColumn("dbo.Providers", "Password", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            RenameIndex(table: "dbo.Products", name: "IX_CategoryFK", newName: "IX_CategoryId");
            RenameColumn(table: "dbo.Products", name: "CategoryFK", newName: "CategoryId");
        }
    }
}
