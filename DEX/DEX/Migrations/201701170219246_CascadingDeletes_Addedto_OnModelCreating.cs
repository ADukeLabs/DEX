namespace DEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CascadingDeletes_Addedto_OnModelCreating : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Companies", "City_Id", "dbo.Cities");
            DropIndex("dbo.Companies", new[] { "City_Id" });
            AlterColumn("dbo.Companies", "City_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Companies", "City_Id");
            AddForeignKey("dbo.Companies", "City_Id", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "City_Id", "dbo.Cities");
            DropIndex("dbo.Companies", new[] { "City_Id" });
            AlterColumn("dbo.Companies", "City_Id", c => c.Int());
            CreateIndex("dbo.Companies", "City_Id");
            AddForeignKey("dbo.Companies", "City_Id", "dbo.Cities", "Id");
        }
    }
}
