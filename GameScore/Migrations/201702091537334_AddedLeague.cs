namespace GameScore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLeague : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "League", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "League");
        }
    }
}
