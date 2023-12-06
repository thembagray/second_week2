using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace second_week2
{
    internal class Movies
    {

        public string title;
        public string director;
        private string rating;
        public Movies(string aTltle, string aDirector, string aRating) {
        
            title = aTltle;
           director = aDirector;
            Rating = aRating;
            
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R") {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
