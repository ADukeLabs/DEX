namespace DEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address_AddedTo_Companies : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Companies", name: "CityId_Id", newName: "City_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_CityId_Id", newName: "IX_City_Id");
            AddColumn("dbo.Companies", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "Address");
            RenameIndex(table: "dbo.Companies", name: "IX_City_Id", newName: "IX_CityId_Id");
            RenameColumn(table: "dbo.Companies", name: "City_Id", newName: "CityId_Id");
        }
    }
}
