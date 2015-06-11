namespace MagsAzureApp.Migrations
{
    using MagsAzureApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MagsAzureApp.Models.AzureMoviesDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MagsAzureApp.Models.AzureMoviesDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
        new Movie
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Romantic Comedy",
            TrailerID = "HEkJAaGhJhQ",
            ImagePath = "https://cannoliandgun.files.wordpress.com/2015/05/when-harry-met-sally-poster.jpg",
            Rating = 2,
        },
        new Movie
        {
            Title = "28 Days Later",
            ReleaseDate = DateTime.Parse("2003-2-14"),
            Genre = "Horror",
            TrailerID = "embed/HEkJAaGhJhQ",
            ImagePath = "https://weallscreen.files.wordpress.com/2012/08/28-days-later.jpg",
            Rating = 5,
        },

        new Movie
        {
            Title = "House Of Wax",
            ReleaseDate = DateTime.Parse("1953-4-10"),
            Genre = "Horror",
            Producer = "Bryan Foy",
            ImagePath = "http://www.doctormacro.com/Images/Price,%20Vincent/Annex/Annex%20-%20Price,%20Vincent%20(House%20of%20Wax)_01.jpg",
            Rating = 5,
        },

         new Movie
         {
             Title = "House On Haunted Hill",
             ReleaseDate = DateTime.Parse("1963-4-29"),
             Genre = "Horror",
             Producer = "Robb White",
             ImagePath = "http://www.doctormacro.com/Images/Price,%20Vincent/Annex/Annex%20-%20Price,%20Vincent%20(House%20on%20Haunted%20Hill)_01.jpg",
             Rating = 5,
         },

        new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

         new Movie
         {
             Title = "Ghostbusters ",
             ReleaseDate = DateTime.Parse("1984-3-13"),
             Genre = "Comedy",
             ImagePath = "http://upload.wikimedia.org/wikipedia/en/e/ee/Ghostbusters_logo.svg",
             Rating = 5,
         },

         new Movie
         {
             Title = "Ghostbusters 2",
             ReleaseDate = DateTime.Parse("1986-2-23"),
             Genre = "Comedy",
             ImagePath = "http://upload.wikimedia.org/wikipedia/en/e/ee/Ghostbusters_logo.svg",
             Rating = 4,
         },

       new Movie
       {
           Title = "Rio Bravo",
           ReleaseDate = DateTime.Parse("1959-4-15"),
           Genre = "Western",
           Rating = 3,
       },

        new Movie
       {
           Title = "Edward Scissorhands",
           ReleaseDate = DateTime.Parse("1990-12-06"),
            Genre = "Romance",
            Producer = "Tim Burton",
            TrailerID = "https://www.youtube.com/watch?v=A5Uc4fCsq6A",
            ImagePath = "http://upload.wikimedia.org/wikipedia/en/3/3b/Edwardscissorhandsposter.JPG",
            Rating = 5,
        },

        new Movie
        {
            Title = "Nigh of the Living Dead",
            ReleaseDate = DateTime.Parse("1968-10-01"),
            Genre = "Horror",
            Producer = "George A. Romero",
            TrailerID = "https://www.youtube.com/watch?v=-_f2Enn8x5s",
            ImagePath = "http://worldworthwatching.com/wp-content/uploads/2012/07/The-Night-of-the-Living-Dead.jpeg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Corpse Bride",
            ReleaseDate = DateTime.Parse("2005-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "https://www.youtube.com/watch?v=G9boDkpEyvc",
            ImagePath = "http://vignette2.wikia.nocookie.net/corpsebride/images/9/99/Corpse-bride.jpg/revision/latest?cb=20120124015137",
            Rating = 5,
        },

                new Movie
        {
            Title = "Braindead",
            ReleaseDate = DateTime.Parse("1992-08-16"),
            Genre = "Comedy",
            Producer = "Peter Jackson",
            ImagePath = "https://londonsurvival.files.wordpress.com/2013/02/braindead-300x300.jpg",
            Rating = 2,
        },

                new Movie
        {
            Title = "April Apocalypse",
            ReleaseDate = DateTime.Parse("2015-02-24"),
            Genre = "Horror",
            Producer = "Jarret Tarnol",
            Rating = 4,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        },

                new Movie
        {
            Title = "Nightmare Before Christmas",
            ReleaseDate = DateTime.Parse("1994-11-25"),
            Genre = "Fantasy",
            Producer = "Tim Burton",
            TrailerID = "http://www.youtube.com/embed/ZuWD-mSUtrU",
            ImagePath = "http://images2.fanpop.com/images/photos/7900000/Nightmare-Before-Christmas-Wallpaper-nightmare-before-christmas-7941065-1024-768.jpg",
            Rating = 5,
        }
   );
        }
    }
}
