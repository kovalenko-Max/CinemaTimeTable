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

        public Dictionary<TimeSpan, Movie> TimeTableElements { get; set; }
        public TimeTable(List<Movie> movies)
        {
            Movies = movies;
        }

        public void CreateTimeTable()
        {
            Graph = new Node(new TimeSpan(14,0,0), new TimeSpan(10, 0, 0), Movies);
            Graph.CreateGraph();
            
            Node optimalBranch = Graph.SelectOptinalBranch();

            TimeTableElements = new Dictionary<TimeSpan, Movie>();
            foreach(Node s in optimalBranch.AllPreviousMovies)
            {
                TimeTableElements.Add(s.Time, s.Movie);
            }
        }
    }
}
