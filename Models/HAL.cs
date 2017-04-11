using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Interface;

namespace BotFactory.Models
{
    class HAL : WorkingUnit,IHAL
    {
        public HAL() : base("HAL", 0.5,7)
        {
        }
    }
}
