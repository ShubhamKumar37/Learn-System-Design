namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage houseBlend = new HouseBlend();
            Console.WriteLine(houseBlend.Description());
            houseBlend = new Soya(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);

            Console.WriteLine(houseBlend.Description());
            Console.WriteLine(houseBlend.Cost());
        }
    }
}
