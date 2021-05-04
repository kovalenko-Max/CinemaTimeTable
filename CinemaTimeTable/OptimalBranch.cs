using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimeTable
{
    public class OptimalBranch
    {
        public int TimeLeft;
        public List<Node> AllPreviousMovies;

        public OptimalBranch(int timeLeft, List<Node> allPreviousMovies)
        {
            TimeLeft = timeLeft;
            AllPreviousMovies = allPreviousMovies;
        }
    }
}
