using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface IPizza
    {
        void PizzaMargherita();
        void PepperoniPizza();
    }

    public class PizzaProvider : IPizza
    {
        public void PepperoniPizza()
        {
            AmericanPizza();
            Console.WriteLine("Получена Пицца с пепперони");
        }
        public void PizzaMargherita()
        {
            Console.WriteLine("Получена Пицца маргарита");
        }
        private void AmericanPizza()
        {
            Console.WriteLine("Получена Пицца американская");
        }
    }

    public interface IBread
    {
        void DarkBread();
        void WhiteBreadWithSesame();
    }

    public class BreadProvider : IBread
    {
        public void DarkBread()
        {
            Console.WriteLine("Получена Тёмная основа");
        }
        public void WhiteBreadWithSesame()
        {
            GetWhiteBread();
            Console.WriteLine("Получена Белая основа с кунжутом");
        }
        private void GetWhiteBread()
        {
            Console.WriteLine("Получена Белая основа");
        }
    }

    public class RestaurantFacade
    {
        private IPizza PizzaProvider;
        private IBread BreadProvider;
        public RestaurantFacade()
        {
            PizzaProvider = new PizzaProvider();
            BreadProvider = new BreadProvider();
        }
        public void GetPepperoniPizza()
        {
            PizzaProvider.PepperoniPizza();
        }
        public void GetPizzaMargherita()
        {
            PizzaProvider.PizzaMargherita();
        }
        public void GetDarkBread()
        {
            BreadProvider.DarkBread();
        }
        public void GetWhiteBreadWithSesame()
        {
            BreadProvider.WhiteBreadWithSesame();
        }
    }
}
