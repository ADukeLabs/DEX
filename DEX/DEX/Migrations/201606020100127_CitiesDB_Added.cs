namespace DEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CitiesDB_Added : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Jobs", new[] { "Company_Id" });
            DropTable("dbo.Jobs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(),
                        DateApplied = c.DateTime(nullable: false),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Jobs", "Company_Id");
            AddForeignKey("dbo.Jobs", "Company_Id", "dbo.Companies", "Id");
        }
    }
}
