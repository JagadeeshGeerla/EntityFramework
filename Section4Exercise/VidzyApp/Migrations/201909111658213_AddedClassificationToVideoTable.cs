namespace VidzyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClassificationToVideoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classification");
        }
    }
}
