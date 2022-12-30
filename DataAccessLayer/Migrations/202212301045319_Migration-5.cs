namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        TicketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.TicketId, cascadeDelete: true)
                .Index(t => t.TicketId);
            
            AddColumn("dbo.Restaurants", "Ticket_Id", c => c.Int());
            CreateIndex("dbo.Restaurants", "Ticket_Id");
            AddForeignKey("dbo.Restaurants", "Ticket_Id", "dbo.Tickets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurants", "Ticket_Id", "dbo.Tickets");
            DropForeignKey("dbo.Orders", "TicketId", "dbo.Tickets");
            DropIndex("dbo.Orders", new[] { "TicketId" });
            DropIndex("dbo.Restaurants", new[] { "Ticket_Id" });
            DropColumn("dbo.Restaurants", "Ticket_Id");
            DropTable("dbo.Orders");
        }
    }
}
