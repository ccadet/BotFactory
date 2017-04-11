using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Common.Interface
{
    public interface IHAL
    {
        int Model { get;  }
        string Name { get;  }
        double speed { get;  }
        double BuildTime       { get; set; }
    }
}
