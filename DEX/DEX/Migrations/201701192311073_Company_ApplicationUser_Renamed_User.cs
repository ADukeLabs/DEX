namespace DEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Company_ApplicationUser_Renamed_User : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Companies", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Companies", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Companies", name: "User_Id", newName: "ApplicationUser_Id");
        }
    }
}
