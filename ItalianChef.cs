using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_week2
{
    internal class ItalianChef:Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Makes Pasta");

        }

        public override void MakeSpeacialDish()
        {
            Console.WriteLine("The chef  Makes a SpeacialDish");
        }
    }
}
