namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForgenKeyForTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stats", "Fumbles", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stats", "Fumbles");
        }
    }
}
