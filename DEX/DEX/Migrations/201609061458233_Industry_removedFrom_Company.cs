namespace DEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Industry_removedFrom_Company : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Companies", "Industry");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "Industry", c => c.String());
        }
    }
}
