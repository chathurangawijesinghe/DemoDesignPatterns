namespace DemoStrategyPattern.Interfaces
{
    public interface Flys
    {
        string fly();
    }

    class ItFlys : Flys
    {
        public string fly()
        {
            return "Flying High";
        }
    }

    class CantFly : Flys
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}
