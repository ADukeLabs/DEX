namespace DEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationUser_Addedto_Company_Object : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Companies", "ApplicationUser_Id");
            AddForeignKey("dbo.Companies", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Companies", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Companies", "ApplicationUser_Id");
        }
    }
}
