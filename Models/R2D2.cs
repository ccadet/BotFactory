using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Interface;


namespace BotFactory.Models
{
    class R2D2 : WorkingUnit,IR2D2
    {
        public R2D2() : base("R2D2", 1.5,5.5)
        {
        }
    }
}
