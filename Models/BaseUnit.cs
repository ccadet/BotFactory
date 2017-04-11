using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using System.Threading;

namespace BotFactory.Models
{
    abstract class BaseUnit : ReportingUnit
    {
        //properties
        public string Name { get; set; }
        public double Speed { get; set; }
        public Coordinates  CurrentPos {
            get { return CurrentPos; }
            set { CurrentPos.X = 0;
                  CurrentPos.Y = 0; }
        }

        //Constructors & methods
        public BaseUnit( string name, double speed=1 , double buildTime=5) :base (buildTime)
        {
            Name = name;
            Speed = speed;
        }
        
        //Permet de faire bouger le rebot tout en respectant le temps de dépplacement nécessaire   
        public async Task<Coordinates> Move(Coordinates arrival) {
            int time = Convert.ToInt32( Math.Round(new Vector().Length(Vector.FromCoordinates(CurrentPos, arrival)) * Speed));
            await Task.Delay(time*1000);
            return arrival;
        }

       


    }
}
