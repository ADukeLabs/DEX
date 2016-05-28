namespace DEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Companies", "CityId_Id", c => c.Int());
            CreateIndex("dbo.Companies", "CityId_Id");
            AddForeignKey("dbo.Companies", "CityId_Id", "dbo.Cities", "Id");
            DropColumn("dbo.Companies", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "Location", c => c.String());
            DropForeignKey("dbo.Companies", "CityId_Id", "dbo.Cities");
            DropIndex("dbo.Companies", new[] { "CityId_Id" });
            DropColumn("dbo.Companies", "CityId_Id");
            DropTable("dbo.Cities");
        }
    }
}
