namespace WeCrab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationshipToMovieAndCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryAndMovieRelations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryAndMovieRelations", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.CategoryAndMovieRelations", "CategoryId", "dbo.Categories");
            DropIndex("dbo.CategoryAndMovieRelations", new[] { "CategoryId" });
            DropIndex("dbo.CategoryAndMovieRelations", new[] { "MovieId" });
            DropTable("dbo.Movies");
            DropTable("dbo.CategoryAndMovieRelations");
        }
    }
}
