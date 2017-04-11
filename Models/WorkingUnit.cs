using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    abstract class WorkingUnit : BaseUnit
    {
      
        //Properties
        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos  { get; set; }
        public bool IsWorking { get; set; }


        //Constructors and methods
        public WorkingUnit(string name, double speed = 1, double buildTime=5) : base(name, speed, buildTime)
        {
        }
        public WorkingUnit(Coordinates parkingPos, Coordinates workingPos ,string name, double speed = 1, double buildTime = 5) : base(name, speed, buildTime)
        {
            ParkingPos = parkingPos;
            WorkingPos = workingPos;
        }


        /*Il est conseillé de découper les différentes taches effectuées par le robot pour aller travailler ou aller se recharger 
        * dans le but de garder le code propre et compréhensif. De plus, il faut que les différentes méthodes crées dans ce but 
        * soient surchargeables par les classes héritant de la classe WorkingUnit pour pouvoir adapter les taches suivant le modèle 
        * du robot. */

        public virtual async void WorkBegins() {
                Coordinates actual= await Move(WorkingPos);
            IsWorking = true;
            }
            public virtual async void WorkEnds() {
                Coordinates actual = await Move(ParkingPos);
            IsWorking = false;        }

}
}
