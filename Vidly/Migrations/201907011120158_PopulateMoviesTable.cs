namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Hangover',1,'1/12/2018','1/12/2016',5)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Die Hard',2,'1/12/2018','1/12/2016',2)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('The Terminator',2,'1/12/2018','1/12/2016',4)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Toy Story',3,'1/12/2018','1/12/2016',11)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Titanic',4,'1/12/2018','1/12/2016',7)");
        }
        
        public override void Down()
        {
        }
    }
}
