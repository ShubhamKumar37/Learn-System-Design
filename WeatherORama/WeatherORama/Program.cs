namespace WeatherORama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();
            SmallTv st = new SmallTv(wd);

            wd.Update(30f, 123f, 21f);
            //st.Display();
        }
    }
}
