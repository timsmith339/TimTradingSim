using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimTradingSim.Code.Interfaces
{
    public interface IInventory
    {
        IElement TakeElement(string name);
        void AddElement(IElement Element);
    }
}
