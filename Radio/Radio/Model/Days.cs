using System;
using System.Collections.Generic;
using System.Text;

namespace Radio.Model
{
    public class Days
    {
        public string DayName { get; set; }
        public List<Broadcast> BroadcastPerDay { get; set; }
        public bool IsVisible { get; set; } = false;

        public Days(string dayname, List<Broadcast> broadcast)
        {
            DayName = dayname;
            BroadcastPerDay = broadcast;
        }
    }
}
