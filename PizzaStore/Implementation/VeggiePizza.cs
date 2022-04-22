using Simple_Factory_Pattern.PizzaStore.Interface;

namespace Simple_Factory_Pattern.PizzaStore.Implementation
{
    public class VeggiePizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Inside VeggiePizza.Bake() method");
        }

        public void Box()
        {
            Console.WriteLine("Inside VeggiePizza.Box() method");
        }

        public void Cut()
        {
            Console.WriteLine("Inside VeggiePizza.Cut() method");
        }

        public void Prepare()
        {
            Console.WriteLine("Inside VeggiePizza.prepare() method");
        }
    }
}