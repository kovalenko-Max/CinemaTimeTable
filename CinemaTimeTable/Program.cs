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
            movies.Add(new Movie("First", new TimeSpan(2,0,0)));
            movies.Add(new Movie("Second", new TimeSpan(2, 0, 0)));
            movies.Add(new Movie("Third", new TimeSpan(1, 0, 0)));
            movies.Add(new Movie("Fourth", new TimeSpan(3, 0, 0)));
            movies.Add(new Movie("Sixth", new TimeSpan(4, 0, 0)));
            movies.Add(new Movie("Seventh", new TimeSpan(5, 0, 0)));
            movies.Add(new Movie("Enghth", new TimeSpan(2, 0, 0)));
            movies.Add(new Movie("Ninth", new TimeSpan(1, 0, 0)));

            List<CinemaHall> cinemaHalls = new List<CinemaHall>();
            cinemaHalls.Add(new CinemaHall(workTimeDuration, movies));
            Cinema cinema = new Cinema(cinemaHalls, movies);

            cinema.CinemaHalls[0].CreateTimeTable();
            var timeTableElements = cinema.CinemaHalls[0].TimeTable.TimeTableElements;
            foreach(var timeTableElement in timeTableElements)
            {
                Console.WriteLine(timeTableElement.Key + " - " + timeTableElement.Value);
            }
        }
    }
}
