using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimTradingSim.Code.Interfaces
{
    public interface IWorld
    {
        IEntity GetEntity(string name);
        void AddEntity(IEntity entity);
    }
}
