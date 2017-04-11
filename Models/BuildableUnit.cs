using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    abstract class BuildableUnit
    {
        //Properties
        public double BuildTime { get; set; }

       
        //Constructors & methods
        public BuildableUnit(double buildTime = 5)
        {
            this.BuildTime = buildTime;
        }

    }
}
