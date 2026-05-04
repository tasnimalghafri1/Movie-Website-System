using System;
using System.Collections.Generic;

namespace MovieWebsiteApp
{
    // Movie Class
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        private int rating;

        public int Rating
        {
            get { return rating; }
            set
            {
                // Validate rating (1–10)
                if (value >= 1 && value <= 10)
                    rating = value;
                else
                    rating = 5; // default
            }
        }

        // Constructor
        public Movie(string title, string genre, int year, int rating = 5)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Rating = rating;
        }
    }

    // User Class
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public User(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"Welcome {Name}!");
        }
    }

    // Review Class
    class Review
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }
        private int rate;

        public int Rate
        {
            get { return rate; }
            set
            {
                if (value >= 1 && value <= 10)
                    rate = value;
                else
                    rate = 5;
            }
        }

        // Constructor
        public Review(string userName, string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Movies
            List<Movie> movies = new List<Movie>()
            {
                new Movie("Ballet Shoes", "Family/Musical", 2007, 7),
new Movie("Be with you", "Romance", 2018, 10),
new Movie("ABCD", "Musical", 2013, 10)
            };

            // Create User
            User u1 = new User("TASNIM", 25);

            // Display Movies
            Console.WriteLine("\nMovies:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title} - {movie.Rating}");
            }

            // Add Review
            List<Review> reviews = new List<Review>();
            reviews.Add(new Review("TASNIM", "Ballet Shoes", "Good movie!", 7));
            reviews.Add(new Review("TASNIM", "Be with you", "Great movie!", 10));
            reviews.Add(new Review("TASNIM", "ABCD", "Great movie!", 10));
            // Display Reviews
            Console.WriteLine("\nReviews:");
            foreach (var review in reviews)
            {
                Console.WriteLine($"{review.UserName} rated {review.MovieTitle}: {review.Rate} - {review.Comment}");
            }
        }
    }
}