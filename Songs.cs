using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_week2
{
    internal class Songs
    {

        public string title;
        public string artist;
        private int duration;

        public static int songCount = 0;
        
        public Songs(string aTltle, string aArtist, int aDuration) {
        
            this.title = aTltle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;
        }

    }
}
