using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MovieReviewWebsite.Models; 
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class FilmDataInitialiser: DropCreateDatabaseAlways<FilmContext> 
    {
        protected override void Seed(FilmContext context)
        {
            Genre genre1 = new Genre();
            genre1.GenreID = 1;
            genre1.Name = "Action";
            genre1.Description = "Action Genre";
            context.Genres.Add(genre1); 

            Film film1 = new Film();
            film1.FilmID = 1;
            film1.Name = "Aquaman";
            film1.Description = "Aquaman is a film";
            film1.FilmLength = "2h 22m";
            film1.GenreID = 1;
            film1.Rating = "5 Stars";
            //film1.GenreID = genre1.GenreID;
            context.Films.Add(film1);

            Genre genre2 = new Genre();
            genre2.GenreID = 2;
            genre2.Name = "Horror";
            genre2.Description = "Horror Genre";
            context.Genres.Add(genre2);

            Film film2 = new Film();
            film2.FilmID = 2;
            film2.Name = "The Lord of the Ring";
            film2.Description = "The Lord of the Ring is a film";
            film2.FilmLength = "2h 30m";
            film2.GenreID = 2;
            film2.Rating = "5 Stars";
            //film2.GenreID = genre2.GenreID;
            context.Films.Add(film2);

            Genre genre3 = new Genre();
            genre3.GenreID = 3;
            genre3.Name = "Adventure";
            genre3.Description = "Adventure Genre";
            context.Genres.Add(genre3);

            Film film3 = new Film();
            film3.FilmID = 3;
            film3.Name = "Avatar";
            film3.Description = "Avatar is a film";
            film3.FilmLength = "2h 30m";
            film3.GenreID = 3;
            film3.Rating = "4 Stars";
            //film2.GenreID = genre3.GenreID;
            context.Films.Add(film3);


            Genre genre4 = new Genre();
            genre4.GenreID = 4;
            genre4.Name = "Drama";
            genre4.Description = "Drama Genre";
            context.Genres.Add(genre4);

            Film film4 = new Film();
            film4.FilmID = 4;
            film4.Name = "The Shape of Water";
            film4.Description = "The Shape of Water is a film";
            film4.FilmLength = "2h 19m";
            film4.GenreID = 4;
            film4.Rating = "4.5 Stars";
            //film4.GenreID = genre4.GenreID;
            context.Films.Add(film4);

            Film film5 = new Film();
            film5.FilmID = 5;
            film5.Name = "Gravity";
            film5.Description = "Gravity is a film";
            film5.FilmLength = "1h 45m";
            film5.GenreID = 4;
            film5.Rating = "5 Stars";
            //film2.GenreID = genre5.GenreID;
            context.Films.Add(film5);

            Genre genre6 = new Genre();
            genre6.GenreID = 6;
            genre6.Name = "Romance";
            genre6.Description = "Romance Genre";
            context.Genres.Add(genre6);

            Film film6 = new Film();
            film6.FilmID = 6;
            film6.Name = "Up in the Air";
            film6.Description = "Up in the Air is a film";
            film6.FilmLength = "2h 15m";
            film6.GenreID = 6;
            film6.Rating = "4 Stars";
            //film2.GenreID = genre6.GenreID;
            context.Films.Add(film6);

            Genre genre7 = new Genre();
            genre7.GenreID = 7;
            genre7.Name = "Comedy";
            genre7.Description = "Comedy Genre";
            context.Genres.Add(genre7);

            Film film7 = new Film();
            film7.FilmID = 7;
            film7.Name = "Their Finest";
            film7.Description = "Their Finest is a film";
            film7.FilmLength = "2h 30m";
            film7.GenreID = 7;
            film7.Rating = "4 Stars";
            //film7.GenreID = genre7.GenreID;
            context.Films.Add(film7);

            Genre genre8 = new Genre();
            genre8.GenreID = 8;
            genre8.Name = "Drama,Romance";
            genre8.Description = "Drama,Romance Genre";
            context.Genres.Add(genre8);

            Film film8 = new Film();
            film8.FilmID = 8;
            film8.Name = "Before Sunset";
            film8.Description = "Before Sunset is a film";
            film8.FilmLength = "1h 20m";
            film8.GenreID = 3;
            film8.Rating = "5 Stars";
            //film8.GenreID = genre8.GenreID;
            context.Films.Add(film8);

            Genre genre9 = new Genre();
            genre9.GenreID = 9;
            genre9.Name = "Kids & Family";
            genre9.Description = "Kids & Family Genre";
            context.Genres.Add(genre9);

            Film film9 = new Film();
            film9.FilmID = 9;
            film9.Name = "Cinderella";
            film9.Description = "Cinderella is a film";
            film9.FilmLength = "1h 59m";
            film9.GenreID = 9;
            film9.Rating = "4.5 Stars";
            //film9.GenreID = genre9.GenreID;
            context.Films.Add(film9);

            Film film10 = new Film();
            film10.FilmID = 10;
            film10.Name = "The Mask of Zorro";
            film10.Description = "The Mask of Zorro is a film";
            film10.FilmLength = "1h 45m";
            film10.GenreID = 1;
            film10.Rating = "5 Stars";
            //film10.GenreID = genre10.GenreID;
            context.Films.Add(film10);

            base.Seed(context); 
        }
    }
}