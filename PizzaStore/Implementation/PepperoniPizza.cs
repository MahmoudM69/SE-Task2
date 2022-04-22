using Simple_Factory_Pattern.PizzaStore.Interface;

namespace Simple_Factory_Pattern.PizzaStore.Implementation
{
    public class PepperoniPizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Inside PepperoniPizza.Bake() method");
        }

        public void Box()
        {
            Console.WriteLine("Inside PepperoniPizza.Box() method");
        }

        public void Cut()
        {
            Console.WriteLine("Inside PepperoniPizza.Cut() method");
        }

        public void Prepare()
        {
            Console.WriteLine("Inside PepperoniPizza.prepare() method");
        }
    }
}