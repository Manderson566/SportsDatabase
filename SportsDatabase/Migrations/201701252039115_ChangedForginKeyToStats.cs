namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedForginKeyToStats : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Stats_Id", "dbo.Stats");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Stats_Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            AddColumn("dbo.Stats", "Player_Id", c => c.Int());
            AddColumn("dbo.Stats", "Team_Id", c => c.Int());
            CreateIndex("dbo.Stats", "Player_Id");
            CreateIndex("dbo.Stats", "Team_Id");
            AddForeignKey("dbo.Stats", "Player_Id", "dbo.Players", "Id");
            AddForeignKey("dbo.Stats", "Team_Id", "dbo.Teams", "Id");
            DropColumn("dbo.Players", "Stats_Id");
            DropColumn("dbo.Players", "Team_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Team_Id", c => c.Int());
            AddColumn("dbo.Players", "Stats_Id", c => c.Int());
            DropForeignKey("dbo.Stats", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Stats", "Player_Id", "dbo.Players");
            DropIndex("dbo.Stats", new[] { "Team_Id" });
            DropIndex("dbo.Stats", new[] { "Player_Id" });
            DropColumn("dbo.Stats", "Team_Id");
            DropColumn("dbo.Stats", "Player_Id");
            CreateIndex("dbo.Players", "Team_Id");
            CreateIndex("dbo.Players", "Stats_Id");
            AddForeignKey("dbo.Players", "Team_Id", "dbo.Teams", "Id");
            AddForeignKey("dbo.Players", "Stats_Id", "dbo.Stats", "Id");
        }
    }
}
