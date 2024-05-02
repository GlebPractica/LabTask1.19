using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Fan
    {
        private List<Vote> _songs;

        public Fan() => _songs = new List<Vote>();

        public void AddSong(Vote song) => _songs.Add(song);

        public List<Vote> GetSongs() => _songs;
    }
}
