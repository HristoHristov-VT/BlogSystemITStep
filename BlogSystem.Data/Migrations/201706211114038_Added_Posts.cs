namespace BlogSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Posts : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "AuthorId", c => c.String());
            AlterColumn("dbo.Posts", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "AuthorId", c => c.Int(nullable: false));
        }
    }
}
