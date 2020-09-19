using System;

abstract class Duck
{
    protected FlyBehavior flyBehavior;
    protected QuackBehavior quackBehavior;

    public void performQuack()
    {
        quackBehavior.quack();
    }

    public void swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }

    public abstract void display();

    public void performFly()
    {
        flyBehavior.fly();
    }

    public void setFlyBehavior(FlyBehavior fb)
    {
        flyBehavior = fb;
    }

    public void setQuackBehavior(QuackBehavior qb)
    {
        quackBehavior = qb;
    }
}