namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Restaurants", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.Restaurants", new[] { "Ticket_Id" });
            DropColumn("dbo.Restaurants", "Ticket_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "Ticket_Id", c => c.Int());
            CreateIndex("dbo.Restaurants", "Ticket_Id");
            AddForeignKey("dbo.Restaurants", "Ticket_Id", "dbo.Tickets", "Id");
        }
    }
}
