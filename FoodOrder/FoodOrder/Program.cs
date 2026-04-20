namespace FoodOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder Pizza = new Pizza();
            Pizza = new Paneer(Pizza);
            Pizza = new Cheese(Pizza);
            Pizza = new Cheese(Pizza);
            //Pizza = new Patty(Pizza); // validation test case for burgers that can only have patty in them 

            Console.WriteLine(Pizza.Cost());
            Console.WriteLine(Pizza.Description());

            IOrder Burger = new Burger();
            Burger = new Paneer(Burger);
            Burger = new Patty(Burger);
            Burger = new Cheese(Burger);
            Burger = new Patty(Burger);
            Burger = new Cheese(Burger);
            
            Console.WriteLine(Burger.Cost());
            Console.WriteLine(Burger.Description());
        }
    }
}
