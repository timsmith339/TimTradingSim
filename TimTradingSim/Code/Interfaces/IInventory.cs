﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimTradingSim.Code.Data;

namespace TimTradingSim.Code.Interfaces
{
    public interface IInventory
    {
        IElement GetElement(ElementsList.Elements element);
        void AddElement(IElement element);
    }
}
