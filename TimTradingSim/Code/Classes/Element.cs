using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimTradingSim.Code.Interfaces;

namespace TimTradingSim.Code.Classes
{
    public abstract class Element : IElement
    {
        private string _Name { get; set; }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name == null)
                    _Name = Name;
                else
                    throw new Exception("This element's name is is already set.");
            }
        }

        private Int32 _Quantity { get; set; }
        public Int32 GetQuantity
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
    }
}
