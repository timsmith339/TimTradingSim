using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimTradingSim.Code.Interfaces
{
    public interface ITradeLogic
    {
        void SendOffer();
        ITradeNegotiation RecieveOffer();
    }
}
