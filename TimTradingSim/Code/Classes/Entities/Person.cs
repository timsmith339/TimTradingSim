using TimTradingSim.Code.Interfaces;

namespace TimTradingSim.Code.Classes.Entities
{
    public class Person : IEntity
    {        
        public ITradeLogic _tradeLogic { get; set; }
        public IInventory _inventory { get; set; }
        
        public string Name { get; set; }

        public Person(ITradeLogic tradeLogic, IInventory inventory)
        {
            _tradeLogic = tradeLogic;
            _inventory = inventory;
        }
    }
}
