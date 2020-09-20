abstract class Beverage
{
    protected string description = "Unkown Beverage";
    public virtual string getDescription() => description;

    public abstract double cost();
}