using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimTradingSim.Code.Data;

namespace TimTradingSim.Code.Interfaces
{
    public interface ITradeEngine
    {
        IElement Purchase(ElementsList.Elements request, IElement payment);
        IElement Sell(ElementsList.Elements request, IElement payment);
    }
}
