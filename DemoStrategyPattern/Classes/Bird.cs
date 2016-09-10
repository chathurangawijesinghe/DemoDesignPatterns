using DemoStrategyPattern.Interfaces;

namespace DemoStrategyPattern.Classes
{
    public class Bird : Animal
    {
        public Bird() : base() {
            Sound = "Tweet";

            flyingType = new ItFlys();
        }
    }
}
