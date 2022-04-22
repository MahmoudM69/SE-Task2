using Simple_Factory_Pattern.PizzaStore.Interface;

namespace Simple_Factory_Pattern.PizzaStore
{
    public class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza? pizza = SimplePizzaFactory.CreatePizza(type);
            pizza?.Prepare();
            pizza?.Bake();
            pizza?.Cut();
            pizza?.Box();
        }
    }
}