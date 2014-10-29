using System;
using TimTradingSim.Code.Data;

namespace TimTradingSim.Code.Interfaces
{
    public interface IElement
    {
        ElementsList.Elements ElementType { get; set; }
        Int32 Quantity { get; }
        void Merge(IElement element);
    }
}
