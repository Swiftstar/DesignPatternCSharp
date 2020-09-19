class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new Quack();
    }

    public override void display()
    {
        System.Console.WriteLine("I'm a model duck");
    }
}