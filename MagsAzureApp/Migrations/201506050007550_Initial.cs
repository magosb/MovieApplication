namespace MagsAzureApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        Movie_ID = c.Int(),
                    })
                .PrimaryKey(t => t.FileId)
                .ForeignKey("dbo.Movies", t => t.Movie_ID)
                .Index(t => t.Movie_ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Producer = c.String(maxLength: 60),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(maxLength: 600),
                        Image = c.Binary(),
                        ImagePath = c.String(),
                        TrailerID = c.String(),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "Movie_ID", "dbo.Movies");
            DropIndex("dbo.Images", new[] { "Movie_ID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Images");
        }
    }
}
