using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimeTable
{
    public class Movie
    {
        public string Name { get; set; }
        public TimeSpan Duration;

        public Movie(string name, TimeSpan duration )
        {
            Name = name;
            Duration = duration;
        }
    }
}

