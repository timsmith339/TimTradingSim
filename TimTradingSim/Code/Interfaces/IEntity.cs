using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimTradingSim.Code.Interfaces
{
    public interface IEntity
    {
        String Name { get; set; }
        IInventory _inventory { get; set; }
        ITradeLogic _tradeLogic { get; set; }
    }
}
