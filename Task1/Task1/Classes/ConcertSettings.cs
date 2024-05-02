using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class ConcertSettings
    {
        public int ConcertID { get; set; }
        public string Name { get; set; }
        public int TicketPrice { get; set; }
        public string Venue { get; set; }
        public int MaxSongs { get; set; }
    }
}
