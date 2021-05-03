using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimeTable
{
    public class Movie : ICloneable
    {
        public string Name { get; set; }
        public int Duration;

        public Movie(string name, int duration )
        {
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Name} ({Duration})";
        }

        public object Clone()
        {
            Movie cloneMovie = new Movie(Name, Duration);
            return cloneMovie;
        }
    }
}

