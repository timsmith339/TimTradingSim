using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimTradingSim.Code.Data;
using TimTradingSim.Code.Interfaces;

namespace TimTradingSim.Code.Classes
{
    public class Inventory : IInventory
    {
        private List<IElement> Elements { get; set; }

        public Inventory()
        {
            Elements = new List<IElement>();
        }

        public IElement GetElement(ElementsList.Elements element)
        {
            if (Elements.Any(e => e.ElementType == element))
            {
                var returnElement = Elements.FirstOrDefault(e => e.ElementType == element);
                Elements.RemoveAll(e => e.ElementType == element);
                return returnElement;
            }

            return null;
        }

        public void AddElement(IElement element)
        {
            if (Elements.Any(e => e.ElementType == element.ElementType))
            {
                Elements.First(e => e.ElementType == element.ElementType).Merge(element);
            }
            else
            {
                Elements.Add(element);
            }
        }
    }
}
