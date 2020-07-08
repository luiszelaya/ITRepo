namespace JobBoard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Jobs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Job_Comments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "Job_Comments");
        }
    }
}
