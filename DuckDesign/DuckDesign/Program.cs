namespace DuckDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealDuck realDuck = new RealDuck();
            RubberDuck rubberDuck = new RubberDuck();
            FlyWithRocketDuck flyWithRocketDuck = new FlyWithRocketDuck();
            YellowDuck yd = new YellowDuck(realDuck, realDuck);
            yd.Fly();
            yd.Quack();

            //Duck duck = new Duck(realDuck, realDuck);
            //duck.Fly();
            //duck.Quack();
            
            //Duck duck2 = new Duck(rubberDuck, rubberDuck);
            //duck2.Fly();
            //duck2.FlyBehaviour = flyWithRocketDuck;
            //duck2.Fly();
            //duck2.Quack();

            //Duck duck3 = new Duck(flyWithRocketDuck, flyWithRocketDuck);
            //duck3.Fly();
            //duck3.Quack();
        }
    }
}
