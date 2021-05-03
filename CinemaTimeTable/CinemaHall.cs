using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimeTable
{
    public class CinemaHall
    {
        public TimeSpan WorkDayDuration { get; set; }

        public CinemaHall(TimeSpan workDayDuration)
        {
            WorkDayDuration = workDayDuration;
        }
    }
}
