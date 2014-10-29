using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimTradingSim.Code.Data;
using TimTradingSim.Code.Interfaces;

namespace TimTradingSim.Code.Classes
{
    public abstract class Element : IElement
    {
        private ElementsList.Elements _ElementType { get; set; }
        public ElementsList.Elements ElementType
        {
            get { return _ElementType; }
            set { _ElementType = value; }
        }

        private Int32 _Quantity { get; set; }
        public Int32 Quantity
        {
            get { return _Quantity; }
            set 
            {
                if (value > 0)
                    _Quantity = value;
                else
                    throw new Exception("Quantity can not be less than 0.");
            }
        }

        public void Merge(IElement element)
        {
            if (ElementType == element.ElementType)
            {
                Quantity += element.Quantity;
            }
            else
            {
                throw new Exception("Cannot merge two different element types.");
            }
        }
    }
}
