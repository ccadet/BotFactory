using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
    public class Vector
    {
        //Properties
        public double X { get; set; }
        public double Y { get; set; }


        //Constructors & methods

        //retourne le vecteur à partir des coordonnées
        public static Vector  FromCoordinates(Coordinates begin , Coordinates end) {
            return new Vector{ X=end.X - begin.X, Y= end.Y - begin.Y }; 
        }

        //longeur d'un vecteur
        public double Length(Vector v)
        {
            return Math.Sqrt(Math.Pow(v.X, 2)+ Math.Pow(v.Y, 2));
        }


    }
}
