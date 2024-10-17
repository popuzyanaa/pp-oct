using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_winforms
{
    public class Spending
    {
        public string Title {  get; set; }
        public float Count { get; set; }
        public DateTime Time { get; set; } 

        public Spending(string title, float count, DateTime time)
        {
            Title = title;
            Count = count;
            Time = time;
        }

        public override string ToString()
        {
            return $"{Title}: потрачено {Count} {Time}";
        }
    }
}
