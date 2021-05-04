using System;
using System.Collections.Generic;

namespace CinemaTimeTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            int workTimeDuration = 5;

            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("First", 2));
            movies.Add(new Movie("Second", 2));
            movies.Add(new Movie("Third", 1));
            movies.Add(new Movie("Fourth", 3));
            movies.Add(new Movie("Sixth", 4));
            movies.Add(new Movie("Seventh", 5));
            movies.Add(new Movie("Enghth", 2));
            movies.Add(new Movie("Ninth", 1));

            List<CinemaHall> cinemaHalls = new List<CinemaHall>();
            cinemaHalls.Add(new CinemaHall(workTimeDuration, movies));
            Cinema cinema = new Cinema(cinemaHalls, movies);

            cinema.CinemaHalls[0].CreateTimeTable();
        }
    }
}
