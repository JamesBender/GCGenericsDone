using System.Collections.Generic;
using WithoutGenerics.Entities;

namespace WithoutGenerics
{
    public class OrderRepository
    {
                private readonly DataBase _dataBase;

        public OrderRepository()
        {
            _dataBase = new DataBase();
        }

        public int Save(Order entity)
        {
            return _dataBase.Save(entity);
        }

        public Order GetById(int id)
        {
            var order = _dataBase.GetById(id) as Order;
            return order;
        }

        public IList<Order> GetAll
        {
            get
            {
                return _dataBase.GetAllOrder();
            }
        }  
    }
}