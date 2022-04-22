using Simple_Factory_Pattern.PizzaStore.Interface;

namespace Simple_Factory_Pattern.PizzaStore.Implementation
{
    class CheesePizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Inside CheesePizza.Bake() method");
        }

        public void Box()
        {
            Console.WriteLine("Inside CheesePizza.Box() method");
        }

        public void Cut()
        {
            Console.WriteLine("Inside CheesePizza.Cut() method");
        }

        public void Prepare()
        {
            Console.WriteLine("Inside CheesePizza.prepare() method");
        }
    }
}