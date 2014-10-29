using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimTradingSim.Code.Interfaces;

namespace TimTradingSim.Code.Classes.Entities
{
    public class Person : IEntity
    {        
        public ITradeLogic _tradeLogic { get; set; }
        public IInventory _inventory { get; set; }

        public string Name { get; set; }
    }
}
