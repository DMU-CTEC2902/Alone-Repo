using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColourMatch
{
    public class ColourHelper
    {

        public static int Distance(Color firstColour, Color secondColour)
        {
         
            int redDistance = Math.Abs(firstColour.R - secondColour.R);
            int greenDistance = Math.Abs(firstColour.G - secondColour.G);
            int blueDistance = Math.Abs(firstColour.B - secondColour.B);

            int distance = (int)Math.Sqrt(redDistance * redDistance + greenDistance * greenDistance + blueDistance * blueDistance);

            return distance;
        }
    }
}
