using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
namespace BotFactory.Factories
{
    class UnitFactory
    {
        //Properties
        public int QueueCapacity { get;}
        public int StorageCapacity { get;}
        public Queue<FactoryQueueElement> Queue { get; set; }
        public List<ITestingUnit> Storage { get; set; }

        //Constructors and methods
        public UnitFactory(int queueCapacity, int storageCapacity)
        {
            QueueCapacity = queueCapacity;
            StorageCapacity = storageCapacity;
        }
        public void AddWorkableUnitToQueue(string modele, string name, Coordinates parkingPos, Coordinates WorkingPos) {

        }


    }
}
