using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimeTable
{
    public class Cinema
    {
        public List<CinemaHall> CinemaHalls;

        public Cinema()
        {
            CinemaHalls = new List<CinemaHall>();
        }
    }
}
