namespace MyFirstBlazorApp.Shared
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    //public class somthing
    //{
    //    public somthing()
    //    {
    //        var a = new WeatherForecast();
    //        var b = a.GetType().GetMethod(nameof(WeatherForecast.Equals));
    //        b.Invoke()
    //    }
    //}
}