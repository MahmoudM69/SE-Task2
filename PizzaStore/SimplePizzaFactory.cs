using Simple_Factory_Pattern.PizzaStore.Implementation;
using Simple_Factory_Pattern.PizzaStore.Interface;

namespace Simple_Factory_Pattern.PizzaStore
{
    public class SimplePizzaFactory
    {
        public static Pizza? CreatePizza(string type)
        {
            Pizza pizza;
            switch(type)
            {
                case "Cheese":
                    return pizza = new CheesePizza();

                case "Clam":
                    return pizza = new ClamPizza();

                case "Pepperoni":
                    return pizza = new PepperoniPizza();

                case "Veggie":
                    return pizza = new VeggiePizza();
            }
            return null;   
        }
    }
}