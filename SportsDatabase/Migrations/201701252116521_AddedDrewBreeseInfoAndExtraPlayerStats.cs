namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDrewBreeseInfoAndExtraPlayerStats : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "YearsPlayedForTeam", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "College", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "College");
            DropColumn("dbo.Players", "YearsPlayedForTeam");
        }
    }
}
