using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    abstract class ReportingUnit : BuildableUnit
    {
        public ReportingUnit(double buildTime=5) : base (buildTime)
        {

        }

        public event UnitStatusChangedDelegate UnitStatusChanged;
        public virtual void OnStatusChanged(StatusChangedEventArgs eventArgs) {
            UnitStatusChanged(this, eventArgs);
        }
        //La méthode OnStatusChanged doit faire appel à UnitStatusChanged en lui passant le nouveau statut. 
    }
}
