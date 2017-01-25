
namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SportsDatabaseAddTeamPayerStats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                        Stats_Id = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stats", t => t.Stats_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Stats_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Touchdowns = c.Int(nullable: false),
                        PassingYards = c.Int(nullable: false),
                        RushingYards = c.Int(nullable: false),
                        Compleations = c.Int(nullable: false),
                        CompleationPercentage = c.Int(nullable: false),
                        Interceptions = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        YearFounded = c.Int(nullable: false),
                        TotalRecord = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "Stats_Id", "dbo.Stats");
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Players", new[] { "Stats_Id" });
            DropTable("dbo.Teams");
            DropTable("dbo.Stats");
            DropTable("dbo.Players");
        }
    }
}
