class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza createPizza(string item)
    {
        if (item.Equals("cheese"))
            return new ChicagoCheesePizza();
        else if (item.Equals("veggie"))
            return new ChicagoVeggiePizza();
        else if (item.Equals("clam"))
            return new ChicagoClamPizza();
        else if (item.Equals("pepperoni"))
            return new ChicagoPepperoniPizza();
        else
            return null;
    }
}