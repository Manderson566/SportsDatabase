namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoedTeamRecord : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teams", "TotalRecord");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "TotalRecord", c => c.Int(nullable: false));
        }
    }
}
