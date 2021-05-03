using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimeTable
{
    public class Node : ICloneable
    {
        public List<Movie> Movies { get; set; }
        public int TimeLeft;

        public Movie Movie;
        public int Time;

        public List<Node> AllPreviousMovies;
        public List<Node> Next;

        public Node(int timeLeft, int time, List<Movie> movies, List<Node> allPreviousMovies = null)
        {
            TimeLeft = timeLeft;
            Time = time;
            Movies = movies;
            Next = new List<Node>();

            if (allPreviousMovies is null)
            {
                AllPreviousMovies = new List<Node>();
            }
            else
            {
                AllPreviousMovies = allPreviousMovies;
            }
        }

        public void CreateGraph()
        {
            foreach (Movie movie in Movies)
            {
                if (movie.Duration <= TimeLeft)
                {
                    List<Node> newAllPreviousMovies = new List<Node>(AllPreviousMovies);
                    Movie = movie;
                    Node previousNode = (Node)this.Clone();
                    newAllPreviousMovies.Add(previousNode);

                    Node nextNode = new Node(TimeLeft - movie.Duration, Time + movie.Duration, Movies, newAllPreviousMovies);
                    Next.Add(nextNode);
                    nextNode.CreateGraph();
                }
            }
        }

        public void WriteAllLeaves()
        {
            if (Next.Count == 0)
            {
                foreach (Node currentMovie in AllPreviousMovies)
                {
                    if (currentMovie.Movie != null)
                    {
                        Console.WriteLine(currentMovie + " ");
                    }
                }

                Console.WriteLine();
            }
            else
            {
                foreach (Node n in Next)
                {
                    n.WriteAllLeaves();
                }
            }
        }

        public override string ToString()
        {
            return $"{Movie.Name}({Movie.Duration}) at {Time}";
        }

        public object Clone()
        {
            Node cloneNode = new Node(TimeLeft, Time, new List<Movie>(Movies), new List<Node>(AllPreviousMovies));

            if (Movie != null)
            {
                cloneNode.Movie = (Movie)Movie.Clone();
            }

            return cloneNode;
        }
    }
}
