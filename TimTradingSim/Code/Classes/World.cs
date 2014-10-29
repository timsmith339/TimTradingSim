using System.Collections.Generic;
using System.Linq;
using TimTradingSim.Code.Interfaces;

namespace TimTradingSim.Code.Classes
{
    public class World : IWorld
    {
        private readonly List<IEntity> _entities;

        public World()
        {
            _entities = new List<IEntity>();
        }

        public IEntity GetEntity(string name)
        {
            return _entities.FirstOrDefault(e => e.Name == name);
        }

        public void AddEntity(IEntity entity)
        {
            if (entity != null)
                _entities.Add(entity);
        }
    }
}
