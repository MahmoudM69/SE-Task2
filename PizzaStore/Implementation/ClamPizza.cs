using Simple_Factory_Pattern.PizzaStore.Interface;

namespace Simple_Factory_Pattern.PizzaStore.Implementation
{
    public class ClamPizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Inside ClamPizza.Bake() method");
        }

        public void Box()
        {
            Console.WriteLine("Inside ClamPizza.Box() method");
        }

        public void Cut()
        {
            Console.WriteLine("Inside ClamPizza.Cut() method");
        }

        public void Prepare()
        {
            Console.WriteLine("Inside ClamPizza.prepare() method");
        }
    }
}