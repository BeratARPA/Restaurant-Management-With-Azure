namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CorporateCustomers", newName: "Customers");
            RenameColumn(table: "dbo.Restaurants", name: "CorporateCustomerId", newName: "CustomerId");
            RenameIndex(table: "dbo.Restaurants", name: "IX_CorporateCustomerId", newName: "IX_CustomerId");
            DropTable("dbo.IndividualCustomers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.IndividualCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            RenameIndex(table: "dbo.Restaurants", name: "IX_CustomerId", newName: "IX_CorporateCustomerId");
            RenameColumn(table: "dbo.Restaurants", name: "CustomerId", newName: "CorporateCustomerId");
            RenameTable(name: "dbo.Customers", newName: "CorporateCustomers");
        }
    }
}
