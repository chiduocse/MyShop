namespace MyShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "MoreImages", c => c.String(storeType: "xml"));
            AddColumn("dbo.Products", "HotFlag", c => c.Boolean());
            AddColumn("dbo.Products", "Tags", c => c.String());
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "MoreImage");
            DropColumn("dbo.Products", "HotLag");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "HotLag", c => c.Boolean());
            AddColumn("dbo.Products", "MoreImage", c => c.String(storeType: "xml"));
            DropColumn("dbo.Products", "OriginalPrice");
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "Tags");
            DropColumn("dbo.Products", "HotFlag");
            DropColumn("dbo.Products", "MoreImages");
        }
    }
}
