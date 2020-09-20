using System;
class PizzaTestDrive
{
    public static void Test()
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoSotre = new ChicagoPizzaStore();

        Pizza pizza = nyStore.orderPizza("cheese");
        Console.WriteLine($"Ethan ordered a {pizza.getName()}\n");

        pizza = chicagoSotre.orderPizza("cheese");
        Console.WriteLine($"Joel ordered a {pizza.getName()}\n");
    }
}