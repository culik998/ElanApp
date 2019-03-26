namespace ElanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class House : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        Price = c.String(),
                        PhoneNumber = c.String(),
                        Discount = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Houses");
        }
    }
}
