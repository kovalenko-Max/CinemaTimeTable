using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimeTable
{
    public class TimeTable
    {
        public List<Movie> Movies;

        public Node Graph;

        public Dictionary<int, Movie> TimeTableElement;
        public TimeTable(List<Movie> movies)
        {
            Movies = movies;
        }

        public void CreateTimeTable()
        {
            Graph = new Node(14, 10, Movies);
            Graph.CreateGraph();
            //Graph.WriteAllLeaves();
            var v = Graph.SelectOptinalBranch();
            Console.WriteLine("______________");
            TimeTableElement = new Dictionary<int, Movie>();
            foreach(Node s in v.AllPreviousMovies)
            {
                TimeTableElement.Add(s.Time, s.Movie);
            }

            foreach(var e in TimeTableElement)
            {
                Console.WriteLine($"At {e.Key}:00 - {e.Value}");
            }
        }
    }
}
