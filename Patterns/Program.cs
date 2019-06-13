using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("1. Мост\n2. Фасад\n3. Компоновщик \nВведите число:");
            string str = Console.ReadLine();
            int switchVar = Convert.ToInt32(str);
            switch (switchVar)
            {
                case 1:
                    {
                        SendOrder sendOrder = new SendSpicyPizzaOrder();
                        sendOrder.restaurant = new DinerOrders();
                        sendOrder.Send();

                        sendOrder.restaurant = new FancyRestaurantOrders();
                        sendOrder.Send();

                        sendOrder = new SendGlutenFreeOrder();
                        sendOrder.restaurant = new DinerOrders();
                        sendOrder.Send();

                        sendOrder.restaurant = new FancyRestaurantOrders();
                        sendOrder.Send();

                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Заказы пиццы\n");

                        var facadeForClient = new RestaurantFacade();

                        facadeForClient.GetPepperoniPizza();
                        facadeForClient.GetPizzaMargherita();

                        Console.WriteLine("\nЗаказы основы\n");

                        facadeForClient.GetDarkBread();
                        facadeForClient.GetWhiteBreadWithSesame();

                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Client client = new Client();
                        
                        Content content = new Content();
                        Console.WriteLine("1:");
                        client.ClientCode(content);
                        
                        Composite tree = new Composite();
                        Composite box1 = new Composite();
                        box1.Add(new Content());
                        box1.Add(new Content());
                        Composite box2 = new Composite();
                        box2.Add(new Content());
                        tree.Add(box1);
                        tree.Add(box2);
                        Console.WriteLine("2:");
                        client.ClientCode(tree);

                        Console.Write("3:\n");
                        client.ClientCode2(tree, content);

                        Console.ReadKey();
                        break;
                    }
            }
        }
    }
    
}
