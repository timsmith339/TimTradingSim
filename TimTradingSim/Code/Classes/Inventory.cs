using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimTradingSim.Code.Interfaces;

namespace TimTradingSim.Code.Classes
{
    public class Inventory : IInventory
    {
        public IElement TakeElement(string name)
        {
            throw new NotImplementedException();
        }

        public void AddElement(IElement Element)
        {
            throw new NotImplementedException();
        }
    }
}
