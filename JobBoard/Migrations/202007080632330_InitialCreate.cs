namespace JobBoard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Job_Title = c.String(),
                        Job_Description = c.String(),
                        Job_CreatedAt = c.DateTime(nullable: false),
                        Job_ExpiresAt = c.DateTime(nullable: false),
                        Job_Comments = c.String(),
                })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jobs");
        }
    }
}
