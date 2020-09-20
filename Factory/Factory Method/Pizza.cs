using System;
using System.Collections.Generic;
abstract class Pizza
{
    protected string name;
    protected string dough;
    protected string sauce;
    protected List<string> toppings = new List<string>();

    public virtual void prepare()
    {
        Console.WriteLine($"Preparing {name}");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        toppings.ForEach((t) => Console.WriteLine(" " + t));
    }

    public virtual void bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void cut()
    {
        Console.WriteLine("Cutting the pizzaa into diagonal slices");
    }

    public virtual void box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public string getName() => name;
}