namespace ObservePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Channel BKCGGaming = new();

            Subscriber Shubham = new();
            Subscriber Mayank = new();

            Shubham.Subscribe(BKCGGaming);
            Shubham.Subscribe(BKCGGaming);
            Mayank.Subscribe(BKCGGaming);

            BKCGGaming.AddNewVideo("Abhi maja aya ");

            Shubham.Display();
            Mayank.Display();

            Shubham.UnSubscribe(BKCGGaming);
            BKCGGaming.AddNewVideo("Badia video ");

            Shubham.Display();
            Mayank.Display();

        }
    }
}
