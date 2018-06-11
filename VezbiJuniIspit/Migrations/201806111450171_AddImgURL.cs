namespace VezbiJuniIspit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImgURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "ImgUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "ImgUrl");
        }
    }
}
