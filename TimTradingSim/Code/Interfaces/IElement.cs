using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimTradingSim.Code.Interfaces
{
    public interface IElement
    {
        String Name { get; set; }
        Int32 GetQuantity { get; }
    }
}
