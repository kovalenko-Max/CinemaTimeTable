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
            Graph = new Node(6, 10, Movies);
            Graph.CreateGraph();
            //Graph.WriteAllLeaves();
            var v = Graph.SelectOptinalBranch();
            foreach(var s in v.AllPreviousMovies)
            {
                Console.WriteLine(s + " ");
            }
        }
    }
}
