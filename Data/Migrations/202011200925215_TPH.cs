namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TPH : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "isBiological", c => c.Int());
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Products", "isBiological");
        }
    }
}
