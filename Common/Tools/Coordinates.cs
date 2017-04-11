using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
    public class Coordinates
    {
        //Porperties
        public double X { get; set; }
        public double Y { get; set; }


        //Constructors and methods
        public override bool Equals(Object obj)
        {  if (obj == null) {
                return false;
            }
            Coordinates coord = obj as Coordinates;
            if ((System.Object)coord == null) {
                return false;
            }
            return (X == coord.X && Y == coord.Y);
        }


    }
}
