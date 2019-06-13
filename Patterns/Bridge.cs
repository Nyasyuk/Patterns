using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface IOrderingSystem
    {
        void Place(string order);
    }

    public abstract class SendOrder
    {
        public IOrderingSystem restaurant;

        public abstract void Send();
    }

    public class SendSpicyPizzaOrder : SendOrder
    {
        public override void Send()
        {
            restaurant.Place("острую пиццу");
        }
    }
    
    public class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            restaurant.Place("классическую пиццу");
        }
    }

    public class DinerOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Заказ на " + order + " в закусочной сделан");
        }
    }
    
    public class FancyRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Заказ на " + order + " в итальянском ресторане сделан");
        }
    }
}
