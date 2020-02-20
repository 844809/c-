namespace CustomPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productname = c.String(nullable: false, maxLength: 128),
                        productid = c.Int(nullable: false),
                        productcost = c.Double(nullable: false),
                        cutomer_name = c.String(),
                        cid = c.String(),
                        purchase = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        product_productname = c.String(maxLength: 128),
                        Customer_productname = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.productname)
                .ForeignKey("dbo.Products", t => t.product_productname)
                .ForeignKey("dbo.Products", t => t.Customer_productname)
                .Index(t => t.product_productname)
                .Index(t => t.Customer_productname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_productname", "dbo.Products");
            DropForeignKey("dbo.Products", "product_productname", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Customer_productname" });
            DropIndex("dbo.Products", new[] { "product_productname" });
            DropTable("dbo.Products");
        }
    }
}
