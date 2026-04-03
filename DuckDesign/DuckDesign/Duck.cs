using System;
using System.Collections.Generic;
using System.Text;

namespace DuckDesign
{
    public class Duck
    {
        public IQuackBehaviour QuackBehaviour { get; set; }
        public IFlyBehaviour FlyBehaviour { get; set; }

        public Duck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour)
        {
            FlyBehaviour = flyBehaviour;
            QuackBehaviour = quackBehaviour;
        }

        public void Fly()
        {
            FlyBehaviour.Fly();
        }
        public void Quack()
        {
            QuackBehaviour.Quack();
        }
    }

    public class RealDuck : IFlyBehaviour, IQuackBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying not really high");
        }
        public void Quack()
        {
            Console.WriteLine("Lets speak for our right");
        }
    }
    public class RubberDuck : IFlyBehaviour, IQuackBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("I cann't fly cause i am a rubber duck");
            }
            public void Quack()
            {
                Console.WriteLine("I Sqweek only");
            }
        }
    class FlyWithRocketDuck: IFlyBehaviour, IQuackBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("We are flying with speed of light");
        }

        public void Quack()
        {
            Console.WriteLine("You will not head what i said cuase i am fast as thuck boii ");
        }
    }
    class YellowDuck: Duck
    {
        public YellowDuck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour) : base(quackBehaviour, flyBehaviour)
        {

        }
    }
}
