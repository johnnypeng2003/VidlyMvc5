namespace VidlyMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableQtyToMovieTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AvailableQty", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AvailableQty");
        }
    }
}
